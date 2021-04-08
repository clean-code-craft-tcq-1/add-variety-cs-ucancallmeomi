using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public class CoolingLimits
    {
        public class HI_ACTIVE_COOLING : ICoolingLimits
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

        public class MED_ACTIVE_COOLING : ICoolingLimits
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


        public class PASSIVE_COOLING : ICoolingLimits
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
