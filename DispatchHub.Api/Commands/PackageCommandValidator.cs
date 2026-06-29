using FluentValidation;
using ValidationMessage = DispatchHub.Api.Commands.ValidationMessages.PackageValidationMessages;

namespace DispatchHub.Api.Commands
{
    public class PackageCommandValidator : AbstractValidator<PackageCommand>
    {
        public PackageCommandValidator()
        {
            RuleFor(x => x.SendType)
                .IsInEnum()
                .WithMessage(ValidationMessage.InvalidType);

            RuleFor(x => x.PackageDestination)
                .NotNull()
                .WithMessage(ValidationMessage.DestinationRequired);

            RuleFor(x => x.SenderContact)
                .ChildRules(contact => 
                    contact.RuleFor(y => y.DDD).NotEmpty())
                .ChildRules(contact => 
                    contact.RuleFor(y => y.Number).NotEmpty())
                .ChildRules(contact => 
                    contact.RuleFor(y => y.Type).IsInEnum().WithMessage(ValidationMessage.InvalidType));
        }
    }
}
