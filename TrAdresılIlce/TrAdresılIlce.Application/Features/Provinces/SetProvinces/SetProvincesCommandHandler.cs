using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrAdresılIlce.Application.Constant;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TS.Result;

namespace TrAdresılIlce.Application.Features.Provinces.SetProvinces;

public sealed class SetProvincesCommandHandler : IRequestHandler<SetProvincesCommand, Result<string>>
{
    private readonly IProvinceRepository _provinceRepository;
    private readonly ICountryRepository _countryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public SetProvincesCommandHandler(IProvinceRepository provinceRepository, ICountryRepository countryRepository, IUnitOfWork unitOfWork)
    {
        _provinceRepository = provinceRepository;
        _countryRepository = countryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<string>> Handle(SetProvincesCommand request, CancellationToken cancellationToken)
    {
        // Ensure country exists or create it (Id handled in its own seeder)
        var country = await _countryRepository.GetByExpressionWithTrackingAsync(x => x.Name == CountryConstants.Türkiye.Name, cancellationToken);
        if (country is null)
        {
            country = new Country { Name = CountryConstants.Türkiye.Name, Code = CountryConstants.Türkiye.Code };
            await _countryRepository.AddAsync(country, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        // If provinces already exist, don't seed again
        var anyProvince = await _provinceRepository.GetAll().AnyAsync(cancellationToken);
        if (anyProvince)
        {
            return Result<string>.Succeed("İller zaten ekli.");
        }

        // Build explicit-id seed set: Id starts at 1 following constants order
        var provinces = ProvinceConstant.Provinces
            .Select((name, index) => new Province { Id = index + 1, Name = name, CountryId = country.Id })
            .ToList();

        var db = (DbContext)_unitOfWork;
        using var tx = await db.Database.BeginTransactionAsync(cancellationToken);
        try
        {
            await db.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Provinces] ON;", cancellationToken);
            await _provinceRepository.AddRangeAsync(provinces, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            await db.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Provinces] OFF;", cancellationToken);
            await tx.CommitAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            await tx.RollbackAsync(cancellationToken);
            return Result<string>.Failure($"Hata: {ex.Message}");
        }

        return Result<string>.Succeed("İller başarıyla eklendi.");
    }
}
