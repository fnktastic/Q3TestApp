using FluentValidation;

namespace Q3TestApp.Application.RxRoomTypes.Commands.MarkJobAsCompleted
{
    public class UpdateAudioCommandValidator : AbstractValidator<MarkJobAsCompletedCommand>
    {
        public UpdateAudioCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
