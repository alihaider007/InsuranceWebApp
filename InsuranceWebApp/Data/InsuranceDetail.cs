using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWebApp.Data
{
    public class InsuranceDetail
    {
        [Display(Name = "Name", Description = "Member's Name")]
        public string Name { get; set; }

        [Display(Name = "Age", Description = "Member's Age")]
        public int Age { get; set; }

        [Display(Name = "Date of Birth", Description = "Member's Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Occupation", Description = "Member's Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Sum Insured", Description = "Sum Insured Amount")]
        [Range(typeof(double), "1000", "1000000")]
        public double SumInsured { get; set; }

        [Display(Name = "Monthly Expenses Total", Description = "Member's Monthly Expenses Total")]
        public double MonthlyExpense { get; set; }

        [Display(Name = "State", Description = "State")]
        public string State { get; set; }

        [Display(Name = "Post Code", Description = "Post Code")]
        [MinLength(4, ErrorMessage = "Post Code cannot be less than 4 digits"), MaxLength(4, ErrorMessage = "Post Code cannot be more than 4 digits")]
        public int PostCode { get; set; }

        [Display(Name = "Total Value", Description = "Total Value")]
        public double TotalValue { get; set; }
    }
}
