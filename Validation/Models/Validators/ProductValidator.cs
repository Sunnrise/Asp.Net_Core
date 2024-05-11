using FluentValidation;

namespace Validation.Models.Validators
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Please type a product name");
            RuleFor(x => x.ProductName).Length(0, 50).WithMessage("Product name must be less than 50 characters");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please type a correct e-mail");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Please type an email");
            
        }
    }
}
