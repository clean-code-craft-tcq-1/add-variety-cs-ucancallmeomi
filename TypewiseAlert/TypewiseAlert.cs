using System;
using System.ComponentModel;
using System.Reflection;
using static TypewiseAlert.BMS_Constants;

namespace TypewiseAlert
{
    public class TypewiseAlert
    {

        public static BreachType inferBreach(double value, double lowerLimit, double upperLimit)
        {
            if (value < lowerLimit)
            {
                return BreachType.TOO_LOW;
            }
            if (value > upperLimit)
            {
                return BreachType.TOO_HIGH;
            }
            return BreachType.NORMAL;
        }

        public static BreachType classifyTemperatureBreach(CoolingType coolingType, double temperatureInC)
        {
            ICoolingLimits coolingLimits = FindObjectInstance.FindInstance(coolingType.ToString()) as ICoolingLimits;
            return inferBreach(temperatureInC, coolingLimits.getLowerLimit, coolingLimits.getUpperLimit);
        }


        public static bool checkAndAlert(AlertTarget alertTarget, BatteryCharacter batteryChar, double temperatureInC)
        {
            bool checkAlert = false;

            BreachType breachType = classifyTemperatureBreach(batteryChar.coolingType, temperatureInC);
            IAlerter alerter = FindObjectInstance.FindInstance(alertTarget.ToString()) as IAlerter;
            if (alerter != null)
            {
                alerter.TriggerBreachAlert(breachType);
                checkAlert = true;
            }

            return checkAlert;

        }
       
    }

    public class FindObjectInstance
    {
        public static Object FindInstance(string className)
        {
            Assembly assemblyName = Assembly.Load(Assembly.GetExecutingAssembly().GetName());
            foreach (Type type in assemblyName.GetTypes())
            {
                if (type.Name.Contains(className))
                {
                    return Activator.CreateInstance(type);
                }
            }
            return null;
        }
    }
}
