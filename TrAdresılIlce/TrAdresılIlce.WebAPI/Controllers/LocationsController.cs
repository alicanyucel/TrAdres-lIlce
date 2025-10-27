using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrAdresılIlce.Application.Features.Countries.GetAllCountiees;
using TrAdresılIlce.Application.Features.Countries.SetCoutries;
using TrAdresılIlce.WebAPI.Abstractions;

namespace TrAdresılIlce.WebAPI.Controllers;

[AllowAnonymous]
public class LocationsController : ApiController
{
    public LocationsController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost]
    public async Task<IActionResult> CreateCountry(SetCountryCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return result.IsSuccessful
            ? Ok(new { success = true, message = "Country synced." })
            : BadRequest(new { success = false, message = "Failed to sync  country.", errors = result.ErrorMessages });
    }
    [HttpPost]
    public async Task<IActionResult> GetAllCountries(GetAllCountriesQuery request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(new { success = true, message = "Countries listed.", data = result });
    }
}
