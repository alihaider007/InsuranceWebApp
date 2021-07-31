using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWebApp.Data
{
    public class Constants
    {
        public enum Occupation
        {
            [Display(Name = "Cleaner Light Manual")]
            CL,
            [Display(Name = "Doctor Professional")]
            DP,
            [Display(Name = "Author White Collar")]
            AW,
            [Display(Name = "Farmer Heavy Manual")]
            FH,
            [Display(Name = "Mechanic Heavy Manual")]
            MH,
            [Display(Name = "Florist Light Manual")]
            FL
        }

        public enum State
        {
            [Display(Name = "State 1")]
            State1,
            [Display(Name = "State 2")]
            State2
        }
    }
}
