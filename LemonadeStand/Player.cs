using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Wallet wallet = new Wallet();
        Recipe recipe = new Recipe();
        public Inventory inventory = new Inventory();
        public string storeName;

        public void SetStoreName ()
        {
            Console.WriteLine("Please Enter the Name of Your Store.");
            storeName = Console.ReadLine();
        }
        public void SetRecipe()
        {
            recipe.createRecipe(inventory);
        }

        public double SetLemonadePrice()
        {

        }
    }
}
