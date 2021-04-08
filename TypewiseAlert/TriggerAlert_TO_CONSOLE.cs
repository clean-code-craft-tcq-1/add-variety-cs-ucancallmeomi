using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class TriggerAlert_TO_CONSOLE : IAlerter
    {
        public void TriggerBreachAlert(BMS_Constants.BreachType breachType)
        {
            Console.WriteLine("There is a {0} breach ", breachType);
        }

    }
}
