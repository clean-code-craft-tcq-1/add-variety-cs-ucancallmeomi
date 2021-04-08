using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class TriggerFakeAlert : IFakeALerter
    {
        bool IsAlertTriggered = false;

        public bool TriggerAlert(BMS_Constants.BreachType breachType)
        {
            IsAlertTriggered = true;

            return IsAlertTriggered;
        }
    }
}
