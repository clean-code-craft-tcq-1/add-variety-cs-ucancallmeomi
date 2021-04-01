using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public interface IAlerter
    {
         void TriggerBreachAlert(BMS_Constants.BreachType breachType);
    }
}
