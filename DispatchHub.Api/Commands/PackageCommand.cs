using DispatchHub.Api.Enums;
using DispatchHub.Api.Models;
using MediatR;

namespace DispatchHub.Api.Commands
{
    public class PackageCommand : IRequest
    {
        public SendTypeEnum SendType { get; set; }
        public Address PackageDestination { get; set; }
        public PhoneInfo SenderContact { get; set; }
    }
}
