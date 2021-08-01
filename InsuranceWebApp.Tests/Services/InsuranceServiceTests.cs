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

        [TestMethod]
        public void When_CalculateInsurance_DoctorProfessional_Then_Response()
        {
            var sut = new InsuranceService();
            request.memberDetail.Age = 30;
            request.memberInsurance.Occupation = "DP";
            request.memberInsurance.SumInsured = 1200;
            var result = sut.CalculateInsurance(request);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(double));
            Assert.AreEqual(0.037, result);
        }

        [TestMethod]
        public void When_CalculateInsurance_MechanicHeavyManual_Then_Response()
        {
            var sut = new InsuranceService();
            request.memberDetail.Age = 30;
            request.memberInsurance.Occupation = "MH";
            request.memberInsurance.SumInsured = 1200;
            var result = sut.CalculateInsurance(request);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(double));
            Assert.AreEqual(0.07, result);
        }

        [TestMethod]
        public void When_CalculateInsurance_AuthorWhiteCollar_Then_Response()
        {
            var sut = new InsuranceService();
            request.memberDetail.Age = 30;
            request.memberInsurance.Occupation = "AW";
            request.memberInsurance.SumInsured = 1200;
            var result = sut.CalculateInsurance(request);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(double));
            Assert.AreEqual(0.048, result);
        }

        [TestMethod]
        public void When_CalculateInsurance_CleanerLightManual_Then_Response()
        {
            var sut = new InsuranceService();
            request.memberDetail.Age = 30;
            request.memberInsurance.Occupation = "CL";
            request.memberInsurance.SumInsured = 1200;
            var result = sut.CalculateInsurance(request);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(double));
            Assert.AreEqual(0.057, result);
        }
    }
}
