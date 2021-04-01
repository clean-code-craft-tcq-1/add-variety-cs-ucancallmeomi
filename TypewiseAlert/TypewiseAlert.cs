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
            ICoolingLimits coolingLimits = FetchInstance(TypeDescriptor.GetClassName(coolingType)) as ICoolingLimits;
            return inferBreach(temperatureInC, coolingLimits.getLowerLimit, coolingLimits.getUpperLimit);
        }


        public static bool checkAndAlert(AlertTarget alertTarget, BatteryCharacter batteryChar, double temperatureInC)
        {
            bool checkAlert = false;

            BreachType breachType = classifyTemperatureBreach(batteryChar.coolingType, temperatureInC);
            IAlerter alerter = FetchInstance(TypeDescriptor.GetClassName(alertTarget)) as IAlerter;
            if (alerter != null)
            {
                alerter.TriggerBreachAlert(breachType);
                checkAlert = true;
            }

            return checkAlert;


        }


        public static Type FetchExecutingInstance(string classname)
        {
            Type instanceType = null;
            AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
            Assembly assembly = Assembly.Load(assemblyName);
            Type[] instanceTypes = assembly.GetTypes();

            foreach (Type type in instanceTypes)
            {
                if (type.Name.Contains(classname))
                    instanceType = type;
            }

            return instanceType;
        }

        public static object FetchInstance(string classname)
        {
            Type instanceType = FetchExecutingInstance(classname);
            return Activator.CreateInstance(instanceType);
        }

    }
}
