using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics.Test.Alerters
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows { get; set; }

        public LEDAlert()
        {
            ledGlows = false;
        }

        public void Alert()
        {
            ledGlows = true;
        }
    }
}
