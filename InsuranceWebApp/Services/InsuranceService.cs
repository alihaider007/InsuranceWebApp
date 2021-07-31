using InsuranceWebApp.Contracts;
using InsuranceWebApp.Data;
using System;

namespace InsuranceWebApp.Services
{
    public class InsuranceService : IInsuranceService
    {
        public double CalculateInsurance(InsuranceDetail insuranceDetail)
        {
            // Total Value  = (Sum Insured * Occupation Rating Factor) /(100 * 12 * Age)
            var ratingFactor = GetRatingFactor(insuranceDetail.memberInsurance.Occupation);

            var totalValue = (insuranceDetail.memberInsurance.SumInsured * ratingFactor) / (100 * 12 * insuranceDetail.memberDetail.Age);

            return Math.Round(totalValue, 3);
        }

        private double GetRatingFactor(string occupation)
        {
            double ratingValue = 0;

            // Since occupation enum values are of 2 characters where the 2 character determines the rating
            // e.g: Doctor with Professional rating is defined as DP and P denotes Professional rating
            var rating = occupation.Substring(1, 1);

            // Hard coding the values here but we can define these ratings in a database and fetch them from there
            switch(rating)
            {
                case "P":
                    ratingValue = 1.1;
                    break;
                case "W":
                    ratingValue = 1.45;
                    break;
                case "L":
                    ratingValue = 1.70;
                    break;
                case "H":
                    ratingValue = 2.1;
                    break;
            }
            return ratingValue;
        }
    }
}
