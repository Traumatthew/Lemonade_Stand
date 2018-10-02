using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Items
    {
        protected double price;

        public Items()
        {

        }

        public double Price
        {
            get => price;
        }
        
    }
}
