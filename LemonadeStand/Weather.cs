using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {

        // weather forcast for the week
        // set weather for each day
        // what is the temp
        // will it rain

        // member variables
        Random random;
        public int temperature;
        public string conditons;
        public int temperatureForecast;
        public string conditionForecast;
        public int[] temperatureToday = new int[] { 70, 80, 90, 100 };
        public string conditionToday = new string[] { "cloudy", "overcast", "rain", "sunny".};

        public void SetTemperture(Random random)
        {
            int temperatureIndex = random.Next(0, 4);

            if (temperatureIndex == 0)
            {
                temperature = 70;
            }
            else if (temperatureIndex == 1)
            {
                temperature = 80;
            }
            else if (temperatureIndex == 2)
            {
                temperature = 90;
            }
            else if (temperatureIndex == 3)
            {
                temperature = 100;
            }

            
      
        }
    }
}
