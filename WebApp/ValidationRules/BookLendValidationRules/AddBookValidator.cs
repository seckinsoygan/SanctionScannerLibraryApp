using Entities;
using FluentValidation;

namespace WebApp.ValidationRules.BookLendValidationRules
{
    public class AddBookValidator : AbstractValidator<Book>
    {
        public AddBookValidator()
        {
            RuleFor(x => x.BookName).NotEmpty().WithMessage("Kitap boş bırakılamaz");
            RuleFor(x => x.BookName).NotNull().WithMessage("Kitap boş bırakılamaz");
            RuleFor(x => x.BookAuthor).NotEmpty().WithMessage("Yazar boş bırakılamaz");
            RuleFor(x => x.BookAuthor).NotNull().WithMessage("Yazar boş bırakılamaz");
            RuleFor(x => x.BookImage).NotEmpty().WithMessage("Resim boş bırakılamaz");
            RuleFor(x => x.BookImage).NotNull().WithMessage("Resim boş bırakılamaz");
        }
    }
}
