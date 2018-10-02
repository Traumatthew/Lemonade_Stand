using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        // set length of time the game will last
        // count each day 
        // display time left
        public List<string> Days;

        public void MakeWeek()
        {
            Days = new List<string>;
            Days.Add("Monday");
            Days.Add("Tuesday");
            Days.Add("Wednesday");
            Days.Add("Thursday");
            Days.Add("Friday");
            Days.Add("Saturday");
            Days.Add("Sunday");
        }

    }
}
