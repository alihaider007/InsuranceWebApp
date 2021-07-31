using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWebApp.Data
{
    public class MemberInsuranceValidator : AbstractValidator<MemberInsurance>
    {
        public MemberInsuranceValidator()
        {
            RuleFor(x => x.Occupation).NotEmpty();
            RuleFor(x => x.SumInsured).InclusiveBetween(1000, 1000000);
            RuleFor(x => x.PostCode).Must(x => x.ToString().Length == 4).WithMessage("Post Code must be 4 digits");
        }
    }
}
