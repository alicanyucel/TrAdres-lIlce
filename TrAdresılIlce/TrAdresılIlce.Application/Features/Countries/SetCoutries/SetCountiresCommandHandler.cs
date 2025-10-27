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
            return Result<string>.Failure("Türkiye zaten kayıtlı.");

        var country = new Country { Name = name, Code = code };

        try
        {
            await _countryRepository.AddAsync(country, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Result<string>.Succeed("Türkiye başarıyla eklendi.");
        }
        catch (DbUpdateException ex)
        {
            var message = ex.InnerException?.Message ?? ex.Message;
            return Result<string>.Failure($"Kaydetme hatası: {message}");
        }
        catch (Exception ex)
        {
            return Result<string>.Failure($"Hata: {ex.Message}");
        }
    }
}