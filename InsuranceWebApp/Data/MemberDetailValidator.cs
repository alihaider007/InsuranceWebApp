using FluentValidation;

namespace InsuranceWebApp.Data
{
    public class MemberDetailValidator : AbstractValidator<MemberDetail>
    {
        public MemberDetailValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Provide Name");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Provide Age"); ;
            RuleFor(x => x.DOB).NotEmpty().WithMessage("Invalid Date of Birth");
            //RuleFor(x => x.SumInsured).InclusiveBetween(1000, 1000000).WithMessage("Sum Insured amount must be between than 1000 and 1000000");
            //RuleFor(x => x.PostCode).NotEqual(4).WithMessage("Post Code must be of 4 digits");
        }
    }
}
