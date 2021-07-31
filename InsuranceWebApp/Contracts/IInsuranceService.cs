using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWebApp.Contracts
{
    public interface IInsuranceService
    {
        Task CalculateInsurance();
    }
}
