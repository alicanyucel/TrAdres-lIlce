using MediatR;

namespace TrAdresılIlce.Application.Features.Countries.GetAllCountiees;

public sealed record GetAllCountriesQuery() : IRequest<List<GetAllCountriesQueryResponse>>;
