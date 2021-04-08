using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class TriggerAlert_TO_EMAIL : IAlerter
    {
        public void TriggerBreachAlert(BMS_Constants.BreachType breachType)
        {
            var breachlevel = new Dictionary<string, string>();
            breachlevel.Add("NORMAL", "normal");
            breachlevel.Add("TOO_LOW", "low");
            breachlevel.Add("TOO_HIGH", "high");

            Console.WriteLine("To: {0}\n", "ab@com");
            Console.WriteLine("Hi, the temperature is {0}\n", breachlevel[breachType.ToString()]);
        }

    }
}
