using AutoMapper;
using GenericRepository;
using MediatR;
using TrAdresılIlce.Domain.Entities;
using TrAdresılIlce.Domain.Repositories;
using TS.Result;

namespace TrAdresılIlce.Application.Features.Countries.SetCoutries;

internal sealed class SetCountryComamndHandler(ICountryRepository countryRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<SetCountryCommand, Result<string>>
{
    public async Task<Result<string>> Handle(SetCountryCommand request, CancellationToken cancellationToken)
    {
        Country country = mapper.Map<Country>(request);
        await countryRepository.AddAsync(country, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Ülke kaydı yapıldı";
    }
}