using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double cashOnHand = 20.00;
        bool broke;
        double finailzePurchase;
        double costOfItem;

        public void DisplayCurrentBalance()
        {
          
            Console.WriteLine(cashOnHand);
        
        }

        public bool CheckIfBroke(double CostOfItem)
        {
            if (cashOnHand < CostOfItem)
            {
                broke = true;
                Console.WriteLine("Insuffient Funds.");
            }
            return broke;
        }

        public double PurcahseItem(double costOfItem)
        {
            finailzePurchase = cashOnHand - costOfItem;
            Console.WriteLine("Purchase Approved!");
            cashOnHand = finailzePurchase;
            return cashOnHand;
        }

        public void DisplayProfit()
        {
            double profit;
            double startCash = 20;
            profit = cashOnHand - startCash;
            Console.WriteLine("You made {0} !");
        }
    }
}
