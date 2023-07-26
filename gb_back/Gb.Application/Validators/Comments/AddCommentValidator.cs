using FluentValidation;
using Gb.Application.Dtos.Comments;
using Gb.Domain.Constants;

namespace Gb.Application.Validators.Comments
{
    public sealed class AddCommentValidator:AbstractValidator<AddCommentDto>
    {
        public AddCommentValidator()
        {
            RuleFor(p => p.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage($"Field can not be empty")
                .MaximumLength(EntityConstants.CommentConstants.MaxNameLength)
                .WithMessage($"Filed should be less than {EntityConstants.CommentConstants.MaxNameLength}")
                .Matches("^[a-zA-Z ]+$")
                .WithMessage($"Field should contains only alphabetic characters");

            RuleFor(p => p.Text)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage($"Field can not be empty")
                .MinimumLength(EntityConstants.CommentConstants.MinCommentLength)
                .WithMessage($"Field should not be less than {EntityConstants.CommentConstants.MinCommentLength} characters")
                .MaximumLength(EntityConstants.CommentConstants.MaxCommentLength)
                .WithMessage($"Field should not be greater than {EntityConstants.CommentConstants.MaxCommentLength} characters");
        }
    }
}
