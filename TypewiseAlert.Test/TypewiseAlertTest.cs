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
    }
}
