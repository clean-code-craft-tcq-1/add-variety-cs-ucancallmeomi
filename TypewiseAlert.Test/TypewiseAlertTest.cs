using System;
using Xunit;
using Moq;
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
        public void InferNormalLimits()
        {
            Assert.True(TypewiseAlert.inferBreach(25, 20, 30) == BMS_Constants.BreachType.NORMAL);
        }

        [Fact]
        public void ClassifyTemperatureBreach()
        {
            Assert.Equal<BreachType>(BMS_Constants.BreachType.TOO_LOW, TypewiseAlert.classifyTemperatureBreach(BMS_Constants.CoolingType.PASSIVE_COOLING, -5));
        }

        [Fact]
        public void CheckAlert()
        {
            var batteryCharacter = new BMS_Constants.BatteryCharacter();
            batteryCharacter.brand = "Bosch";
            batteryCharacter.coolingType = BMS_Constants.CoolingType.HI_ACTIVE_COOLING;

            Assert.True(TypewiseAlert.checkAndAlert(BMS_Constants.AlertTarget.TO_EMAIL, batteryCharacter, 10));
        }

        [Fact]
        public void CheckFakeALert()
        {
            TriggerFakeAlert fakeAlert = new TriggerFakeAlert();
            Assert.True(fakeAlert.TriggerAlert(BMS_Constants.BreachType.NORMAL));
            
        }

        [Fact]
        public void CheckFakeAlertMoq()
        {
            var alert = new Mock<IFakeALerter>();
            alert.Setup(x => x.TriggerAlert(BMS_Constants.BreachType.NORMAL)).Returns(true);
        }


    }
}
