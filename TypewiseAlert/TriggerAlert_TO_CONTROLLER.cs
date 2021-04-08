using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class TriggerAlert_TO_CONTROLLER : IAlerter
    {
        public void TriggerBreachAlert(BMS_Constants.BreachType breachType)
        {
            const ushort header = 0xfeed;
            Console.WriteLine("{} : {}\n", header, breachType);
        }
    }
}
