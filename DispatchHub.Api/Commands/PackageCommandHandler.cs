using MediatR;

namespace DispatchHub.Api.Commands
{
    public class PackageCommandHandler : IRequestHandler<PackageCommand>
    {
        public PackageCommandHandler()
        {
            
        }
        public Task Handle(PackageCommand request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }
    }
}
