using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class TriggerControllerAlert : IAlerter
    {
        public void TriggerBreachAlert(BMS_Constants.BreachType breachType)
        {
            const ushort header = 0xfeed;
            Console.WriteLine("{} : {}\n", header, breachType);
        }
    }
}
