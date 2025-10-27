using MediatR;
using TrAdresılIlce.WebAPI.Abstractions;

namespace TrAdresılIlce.WebAPI.Controllers;


public class LocationsController : ApiController
{
    public LocationsController(IMediator mediator) : base(mediator)
    {
    }
}
