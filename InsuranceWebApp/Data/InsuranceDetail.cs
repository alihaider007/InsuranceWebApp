using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceWebApp.Data
{
    public class InsuranceDetail
    {
        public MemberDetail memberDetail { get; set; }

        public MemberInsurance memberInsurance { get; set; }
    }

    public class MemberDetail
    {
        [Display(Name = "Name", Description = "Member's Name")]
        public string Name { get; set; }

        [Display(Name = "Age", Description = "Member's Age")]
        public int Age { get; set; }

        [Display(Name = "Date of Birth", Description = "Member's Date of Birth")]
        public DateTime DOB { get; set; }
    }

    public class MemberInsurance
    {
        [Display(Name = "Occupation", Description = "Member's Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Sum Insured", Description = "Sum Insured Amount")]
        public double SumInsured { get; set; }

        [Display(Name = "Monthly Expenses Total", Description = "Member's Monthly Expenses Total")]
        public double MonthlyExpense { get; set; }

        [Display(Name = "State", Description = "State")]
        public string State { get; set; }

        [Display(Name = "Post Code", Description = "Post Code")]
        public int PostCode { get; set; }

        [Display(Name = "Total Value", Description = "Total Value")]
        public double TotalValue { get; set; }
    }
}
