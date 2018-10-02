using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        //player needs to buy lemons, ice, sugar, and cups and store it

        // public int lemons;
        public List<Lemons> lemons;
        public List<Sugar> sugar;
        public List<Ice> ice;
        public List<Cups> cups;

        public Inventory()
        {

            lemons = new List<Lemons>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            cups = new List<Cups>();
        }
    }
}
