using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrAdresılIlce.Application.Constant;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TS.Result;

namespace TrAdresılIlce.Application.Features.Countries.SetCoutries;

public sealed class SetCountryCommandHandler : IRequestHandler<SetCountryCommand, Result<string>>
{
    private readonly ICountryRepository _countryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public SetCountryCommandHandler(ICountryRepository countryRepository, IUnitOfWork unitOfWork)
    {
        _countryRepository = countryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<string>> Handle(SetCountryCommand request, CancellationToken cancellationToken)
    {
        var name = CountryConstants.Türkiye.Name;
        var code = CountryConstants.Türkiye.Code;

        var exists = await _countryRepository.ExistsAsync(name, code, cancellationToken);
        if (exists)
            return Result<string>.Succeed("Türkiye zaten ekli.");

        // Insert with explicit Id = 1 using IDENTITY_INSERT
        var country = new Country { Id = 1, Name = name, Code = code };

        var db = (DbContext)_unitOfWork;
        using var tx = await db.Database.BeginTransactionAsync(cancellationToken);
        try
        {
            await db.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Countries] ON;", cancellationToken);
            await _countryRepository.AddAsync(country, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            await db.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Countries] OFF;", cancellationToken);
            await tx.CommitAsync(cancellationToken);
            return Result<string>.Succeed("Türkiye başarıyla eklendi.");
        }
        catch (Exception ex)
        {
            await tx.RollbackAsync(cancellationToken);
            return Result<string>.Failure($"Hata: {ex.Message}");
        }
    }
}