using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public interface IFakeALerter
    {
        bool TriggerAlert(BMS_Constants.BreachType breachType);

    }
}
