using System;
using Xunit;
using static TypewiseAlert.BMS_Constants;

namespace TypewiseAlert.Test
{
    public class TypewiseAlertTest
    {
        [Fact]
        public void InfersBreachLowLimits()
        {
            Assert.True(TypewiseAlert.inferBreach(12, 20, 30) ==
              BMS_Constants.BreachType.TOO_LOW);
        }

        [Fact]
        public void InfersBreachNormalLimits()
        {
            Assert.True(TypewiseAlert.inferBreach(12, 20, 30) ==
              BMS_Constants.BreachType.NORMAL);
        }

        [Fact]
        public void CheckAlertTypeEmail()
        {
            BatteryCharacter batteryCharacter = new BatteryCharacter();
            batteryCharacter.coolingType = CoolingType.MED_ACTIVE_COOLING;
            batteryCharacter.brand = "Exide";
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, -1));

        }
        [Fact]
        public void CheckAlertTypeController()
        {
            BatteryCharacter batteryCharacter = new BatteryCharacter();
            batteryCharacter.coolingType = CoolingType.PASSIVE_COOLING;
            batteryCharacter.brand = "Luminuous";
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 25));
        }

    }
}
