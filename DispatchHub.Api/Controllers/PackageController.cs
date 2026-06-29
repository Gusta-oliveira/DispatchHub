using DispatchHub.Api.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DispatchHub.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackageController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PackageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public IActionResult RequestToShipPackage(PackageCommand command)
        {
            _mediator.Send(command);
            return Ok();
        }
    }
}
