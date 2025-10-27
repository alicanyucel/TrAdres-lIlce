using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TrAdresılIlce.Application.Features.Districts.GetAllDisticts;

public sealed record GetAllDistrictsQuery() : IRequest<List<GetAllDistrictsQueryResponse>>;
