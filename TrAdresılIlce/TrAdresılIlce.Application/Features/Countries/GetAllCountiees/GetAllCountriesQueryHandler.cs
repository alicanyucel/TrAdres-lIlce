using MediatR;
using TrAdresılIlce.Application.Extensions;
using TrAdresılIlce.Domain.Repositories;

namespace TrAdresılIlce.Application.Features.Countries.GetAllCountiees;

public sealed class GetAllCountriesQueryHandler
 : IRequestHandler<GetAllCountriesQuery, List<GetAllCountriesQueryResponse>>
{
    private readonly ICountryRepository _countryRepository;

    public GetAllCountriesQueryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<List<GetAllCountriesQueryResponse>> Handle(
        GetAllCountriesQuery request,
        CancellationToken cancellationToken)
    {
        var countries = await _countryRepository.GetAllAsync(cancellationToken);

        return countries.Select(country =>
        new GetAllCountriesQueryResponse(country.Id, country.Name)
       ).ToList();

    }
}
