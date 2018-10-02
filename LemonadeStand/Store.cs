using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //double BuyLemons;
        //double BuySugar;
        //double BuyIce;
        //double BuyCups;
        public Store(Player player)
        {
            Console.WriteLine("Welcome to the store. What Would you like to purchase?");
            Console.WriteLine("Press 1 for lemons \n.");
            Console.WriteLine("Press 2 for Sugar \n.");
            Console.WriteLine("Press 3 for Ice \n.");
            Console.WriteLine("Press 4 for Cups \n.");

            int use = Console.ReadLine();
            switch (use)
            {
                case 1:
                    BuyLemons(player);
                    break;
                case 2:
                    BuySugar(player);
                    break;
                case 3:
                    BuyIce(player);
                    break;
                case 4:
                    BuyCups(player);
                    break;
                default:
                    Console.WriteLine("Please enter a 1, 2, 3, or 4.");
                    break;
            }
        }
        
        public void BuyLemons(Player player, Lemons lemon)
        {
            Console.WriteLine("How many lemons would you like to purchase? Lemons are .10.");
            int numberOfLemons = int.Parse(Console.ReadLine());
            if (player.wallet.cashOnHand >= numberOfLemons * lemon.Price)
            {
                double costOfLemons = numberOfLemons * lemon.Price;
                player.wallet.cashOnHand -= costOfLemons;
                //add lemons to inventory
                for (int i = numberOfLemons; i > 0; i++)
                {
                    Lemons lemons = new Lemons();
                    inventory.lemons.Add(lemons);
                }
                    
                
               // Console.WriteLine("{0} Lemons have been add to your inventory.");
            }
            else if(player.wallet.cashOnHand < numberOfLemons * lemon.Price)
            {
                Console.WriteLine("Insuffient Funds! Please purchase within your budget.");
            }
           //fix this
        }
        
        public double BuySugar(Player player, Sugar sugar)
        {
            Console.WriteLine("How much sugar would you like to purchase? Sugar is" + sugar.Price + ".");
            int amountOfSugar = int.Parse(Console.ReadLine());
            if (player.wallet.cashOnHand >= amountOfSugar * sugar.Price)
            {
                //subtract $$ from cash
                double costOfSugar = amountOfSugar * sugar.Price;
                player.wallet.cashOnHand = player.wallet.cashOnHand - costOfSugar;
                // add sugar to invetory
                for (int i = amountOfSugar; i > 0; i++)
                {
                    Sugar sugar = new Sugar();
                    inventory.sugars.Add(sugars);
                }


                //player.inventory.sugar += amountOfSugar;

                // Console.WriteLine("{0} Lemons have been add to your inventory.");
            }
            else if(player.wallet.cashOnHand < amountOfSugar * sugar.Price)
            {
                Console.WriteLine("Insuffient Funds! Please purchase within your budget.");
            }
        }

        public double BuyIce(Player player, Ice ice)
        {
            Console.WriteLine("How much sugar would you like to purchase? Sugar is" + ice.Price + ".");
            int amountOfIce = int.Parse(Console.ReadLine());
            if (player.wallet.cashOnHand >= amountOfIce * ice.Price)
            {
                double costOfIce = amountOfIce * ice.Price;
                player.wallet.cashOnHand = player.wallet.cashOnHand - costOfIce;
                for (int i = amountOfIce; i > 0; i++)
                {
                    Ice ice = new Ice();
                    inventory.Ice.Add(ice);
                }


                //player.inventory.ice += amountOfIce;

                // Console.WriteLine("{0} Lemons have been add to your inventory.");
            }
            else if (player.wallet.cashOnHand < amountOfIce * ice.Price)
            {
                Console.WriteLine("Insuffient Funds! Please purchase within your budget.");
            }

        }

        public double BuyCups(Player player, Cups cups)
        {
            Console.WriteLine("How much sugar would you like to purchase? Sugar is" + cups.Price + ".");
            int amountOfCups = int.Parse(Console.ReadLine());
            if (player.wallet.cashOnHand >= amountOfCups * cups.Price)
            {
                // buy cups and subtract cash from wallet
                double costOfCups = amountOfCups * cups.Price;
                player.wallet.cashOnHand = player.wallet.cashOnHand - costOfCups;
                //add cups to inventory
                for (int i = numberOfCups; i > 0; i++)
                {
                    Cups cups = new Cups();
                    inventory.cups.Add(cups);
                }


                //player.inventory.cups += amountOfCups;

                // Console.WriteLine("{0} Lemons have been add to your inventory.");
            }
            else if (player.wallet.cashOnHand < amountOfCups * cups.Price)
            {
                Console.WriteLine("Insuffient Funds! Please purchase within your budget.");
            }

        }
    }
}
