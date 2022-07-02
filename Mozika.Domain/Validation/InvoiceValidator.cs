using Mozika.Domain.Entities;
using FluentValidation;

namespace Mozika.Domain.Validation
{
    public class InvoiceValidator : AbstractValidator<Invoice>
    {
        public InvoiceValidator() {
            RuleFor(i => i.CustomerId).NotNull();
            RuleFor(i => i.InvoiceDate).NotNull();
        }
    }
}