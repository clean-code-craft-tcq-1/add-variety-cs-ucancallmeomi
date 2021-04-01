using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class TriggerEmailAlert : IAlerter
    {
        public void TriggerBreachAlert(BMS_Constants.BreachType breachType)
        {
            Dictionary<string, string> breachlevel = new Dictionary<string, string>);
            breachlevel.Add("NORMAL", "normal");
            breachlevel.Add("TOO_LOW", "low");
            breachlevel.Add("TOO_HIGH", "high");

            Console.WriteLine("To: {}\n", "a.b@c.com");
            Console.WriteLine("Hi, the temperature is {0}\n", breachlevel[breachType.ToString()]);
        }

    }
}
