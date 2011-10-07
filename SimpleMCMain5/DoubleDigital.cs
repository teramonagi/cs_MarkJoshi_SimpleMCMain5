using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMCMain5
{
    class PayOffDoubleDigital : PayOff
    {
        public PayOffDoubleDigital(double lower_level_, double upper_level_)
        {
            this.lower_level = lower_level_;
            this.upper_level = upper_level_;
        }
        public override double Do(double spot)
        {
            double result = 1;
            if (spot <= this.lower_level || spot >= this.upper_level)
            {
                result = 0;
            }
            return result;
        }

        private double lower_level;
        private double upper_level;
    }
}
