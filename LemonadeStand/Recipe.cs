using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int numberOfLemons;
        public int amountOfSugar;
        public int amountOfIce;
        public int numberOfCups;
        public int numberofPitchers;

        public void createRecipe(Inventory inventory)
        {
            Console.WriteLine("Let create a recipe.");
        }

        public void DetermineNumberOfLemons(Inventory inventory)
        {
            Console.WriteLine("How Many Lemons (per pitcher) Do you want to include in your recipe?");
            numberOfLemons = int.Parse(Console.ReadLine());
            if (inventory.lemons.Count >= numberOfLemons)
            {
                for (int i = numberOfLemons; i > 0; i--)
                {
                    inventory.lemons.RemoveAt(0);
                }    
            }
            else
            {
                Console.WriteLine("You do not have enough Lemons on hand.");
            }
        }
        public void DetermineAmountOfSugar(Inventory inventory)
        {
            Console.WriteLine("How much sugar (per pitcher) Do you want to include in your recipe?");
            amountOfSugar = int.Parse(Console.ReadLine());
            if (inventory.sugar.Count >= amountOfSugar)
            {
                for (int i = amountOfSugar; i > 0; i--)
                {
                    inventory.sugar.RemoveAt(0);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough sugar on hand.");
            }
        }
        public void DetermineAmountOfIce(Inventory inventory)
        {
            Console.WriteLine("How Many ice cubes (per pitcher) Do you want to include in your recipe?");
            amountOfIce = int.Parse(Console.ReadLine());
            if (inventory.ice.Count >= amountOfIce)
            {
                for (int i = amountOfIce; i > 0; i--)
                {
                    inventory.ice.RemoveAt(0);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough ice on hand.");
            }
        }
    }
}
