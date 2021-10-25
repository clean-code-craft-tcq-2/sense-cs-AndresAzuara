using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics.Test.Alerters
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent { get; set; }

        public EmailAlert()
        {
            emailSent = false;
        }

        public void Alert()
        {
            emailSent = true;
        }
    }
}
