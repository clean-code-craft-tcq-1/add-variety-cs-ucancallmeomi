using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class CoolingLimits
    {
        public class HighCoolingLimits : ICoolingLimits
        {
            public int getLowerLimit
            {
                get { return 0; }
            }

            public int getUpperLimit
            {
                get { return 45; }
            }

        }

        public class MediumCoolingLimits : ICoolingLimits
        {
            public int getLowerLimit
            {
                get { return 0; }
            }

            public int getUpperLimit
            {
                get { return 40; }
            }

        }


        public class PassiveCoolingLimits : ICoolingLimits
        {
            public int getLowerLimit
            {
                get { return 0; }
            }

            public int getUpperLimit
            {
                get { return 35; }
            }
        }



    }
}
