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
        }
    }
}
