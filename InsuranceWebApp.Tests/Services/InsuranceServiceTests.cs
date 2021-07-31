using AutoBogus;
using InsuranceWebApp.Data;
using InsuranceWebApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsuranceWebApp.Tests.Services
{
    [TestClass]
    public class InsuranceServiceTests
    {
        private InsuranceDetail request;
        [TestInitialize]
        public void Setup()
        {
            request = new AutoFaker<InsuranceDetail>().Generate();
        }

        [TestMethod]
        public void When_CalculateInsurance_Then_Response()
        {
            var sut = new InsuranceService();
            var result = sut.CalculateInsurance(request);
            Assert.IsInstanceOfType(result, typeof(double));
            Assert.IsNotNull(result);
        }
    }
}
