using MediatR;
using System.Collections.Generic;

namespace TrAdresılIlce.Application.Features.Provinces.GetAllProvinces;

public sealed record GetAllProvincesQuery() : IRequest<List<GetAllProvincesQueryResponse>>;
