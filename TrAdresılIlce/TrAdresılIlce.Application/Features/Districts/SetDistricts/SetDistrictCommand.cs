using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TS.Result;

namespace TrAdresılIlce.Application.Features.Districts.SetDistricts
{
    public sealed record SetDistrictCommand() : IRequest<Result<string>>;
}
