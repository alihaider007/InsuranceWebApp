using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWebApp.Data
{
    public class InsuranceDetailValidator : AbstractValidator<InsuranceDetail>
    {
        public InsuranceDetailValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Provide Name");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Provide Age"); ;
            RuleFor(x => x.DOB).NotEmpty().WithMessage("Invalid Date of Birth");
        }
    }
}
