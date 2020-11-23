using FluentValidation;

namespace Q3TestApp.Application.RxRoomTypes.Commands.MarkJobAsCompleted
{
    public class MarkJobAsCompletedCommandValidator : AbstractValidator<MarkJobAsCompletedCommand>
    {
        public MarkJobAsCompletedCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
