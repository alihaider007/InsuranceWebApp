using InsuranceWebApp.Data;

namespace InsuranceWebApp.Contracts
{
    public interface IInsuranceService
    {
        double CalculateInsurance(InsuranceDetail insuranceDetail);
    }
}
