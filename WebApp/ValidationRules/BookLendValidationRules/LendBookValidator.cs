using FluentValidation;
using WebApp.Models.ViewModels;

namespace WebApp.ValidationRules.BookLendValidationRules
{
    public class LendBookValidator : AbstractValidator<LendBookViewModel>
    {
        public LendBookValidator()
        {
            RuleFor(x => x.BookOwner).NotEmpty().WithMessage("İsim Soyisim Boş Geçilemez.");
            RuleFor(x => x.BookOwner).NotNull().WithMessage("İsim Soyisim Boş Geçilemez.");
            RuleFor(x => x.ReturnDate).NotEmpty().WithMessage("Tarih Boş Geçilemez.");
            RuleFor(x => x.ReturnDate).GreaterThan(DateTime.Now).WithMessage("Tarih Bugünden Büyük Olmalı.");
        }
    }
}
