using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public abstract class Abstract_classes
    {
        public abstract bool IsProductExpired(string product);

        public abstract double GetProductPrice (string product);

        public abstract string GetProductInfo(string productName);

        public void OrederProduct (string productName, int qnty, string supplierName)
        {
            Console.WriteLine($"{productName} from {supplierName} ordered in quantity {qnty} units.");
        }

    }

    public class Bannanas : Abstract_classes
    {
        public override string GetProductInfo(string productName)
        {
            return "bannan";
        }

        public override double GetProductPrice(string product)
        {
            return 0.79;
        }

        public override bool IsProductExpired(string product)
        {
            return false;
        }
    }

    public class Chips : Abstract_classes
    {
        public override string GetProductInfo(string productName)
        {
            return "Pringles";
        }

        public override double GetProductPrice(string product)
        {
            return 2.75;
        }

        public override bool IsProductExpired(string product)
        {
            return false;
        }
    }

    public class Water : Abstract_classes
    {
        public override string GetProductInfo(string productName)
        {
            return "Pepsi";
        }

        public override double GetProductPrice(string product)
        {
            return 2.12;
        }

        public override bool IsProductExpired(string product)
        {
            return true;
        }
    }

    public class FruitStore : Abstract_classes
    {
        public override string GetProductInfo(string productName)
        {
            return "India";
        }

        public override double GetProductPrice(string product)
        {
            Random random = new Random();
            double randomPrice = random.Next(1, 11) * 10;
            //Console.WriteLine(randomPrice.ToString());
            return randomPrice;
        }

        public override bool IsProductExpired(string product)
        {
            Random random = new Random();
            int randomNum = random.Next(0, 101);
            if (randomNum >= 0 && randomNum <= 50) { return false; }
            return true;

        }
    }

        public class LiquorMart : Abstract_classes
        {
            public override string GetProductInfo(string productName)
            {
                return productName + " Scotland";
            }

            public override double GetProductPrice(string product)
            {
                Random random = new Random();
                int newRandom = random.Next(5, 21) * 16;
                return newRandom;
            }

            public override bool IsProductExpired(string product)
            {
                DateTime dateTime = DateTime.Now;

                Console.WriteLine(dateTime.AddYears(2));
                return true;
            }
        }

    public class CheeseStore : Abstract_classes
    {
        public override string GetProductInfo(string productName)
        {
            if (productName.Contains("blue"))
            {
                return "France";

            }
            return "Spain";
        }

        public override double GetProductPrice(string product)
        {
            Random rand = new Random();
            int randomCheese = rand.Next(33, 56) / 4;
            return randomCheese;
        }

        public override bool IsProductExpired(string product)
        {
            if (product == "gauda")
            {
                return true;
            }
            return false;
        }
    }
}
