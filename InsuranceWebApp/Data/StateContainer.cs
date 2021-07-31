using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWebApp.Data
{
    public class StateContainer
    {
        public InsuranceDetail insuranceDetail { get; set; }

        public event Action OnChange;

        public void SetProperty(InsuranceDetail value)
        {
            insuranceDetail = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
