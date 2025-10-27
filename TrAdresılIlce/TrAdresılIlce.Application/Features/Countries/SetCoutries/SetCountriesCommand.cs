using MediatR;
using TS.Result;

namespace TrAdresılIlce.Application.Features.Countries.SetCoutries;

public sealed record SetCountryCommand() : IRequest<Result<string>>;
