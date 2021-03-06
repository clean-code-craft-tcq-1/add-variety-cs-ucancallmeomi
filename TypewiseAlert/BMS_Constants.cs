using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class BMS_Constants
    {
        public enum BreachType
        {
            NORMAL,
            TOO_LOW,
            TOO_HIGH
        };

        public enum CoolingType
        {
            PASSIVE_COOLING,
            HI_ACTIVE_COOLING,
            MED_ACTIVE_COOLING
        };

        public enum AlertTarget
        {
            TO_CONTROLLER,
            TO_EMAIL,
            TO_CONSOLE
        };

        public struct BatteryCharacter
        {
            public CoolingType coolingType;
            public string brand;
        }

    }
}
