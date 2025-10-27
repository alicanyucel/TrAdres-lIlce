using MediatR;
using TS.Result;

namespace TrAdresılIlce.Application.Features.Provinces.SetProvinces;

public sealed record SetProvincesCommand() : IRequest<Result<string>>;
