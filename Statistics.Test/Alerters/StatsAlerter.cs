using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Statistics.Test.Alerters
{
    public class StatsAlerter
    {
        public float _maxThreshold { get; set; }
        private IAlerter[] _alerters;
        public StatsAlerter(float maxThreshold)
        {
            _maxThreshold = maxThreshold;
        }

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            _maxThreshold = maxThreshold;
            _alerters = alerters;
        }
        
        public void checkAndAlert(List<float> numbers)
        {
            float maxValue = numbers.Max();
            if(maxValue > _maxThreshold)
            {
                foreach(var alerter in _alerters)
                {
                    alerter.Alert();
                }
            }
        }
    }
}
