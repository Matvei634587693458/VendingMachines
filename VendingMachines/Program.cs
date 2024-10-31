using System.Drawing;

namespace VendingMachines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CoffeeReciept> reciepts = new List<CoffeeReciept>()
            {
                new CoffeeReciept()
                {
                    name = "Американо",
                    water = 10,
                    coffee = 10,
                    milk = 0,
                    enteringCoins = 5
                },
                new CoffeeReciept()
                {
                    name = "Капучино",
                    water = 10,
                    coffee = 5,
                    milk = 5,
                    enteringCoins = 10
                },
                new CoffeeReciept()
                {
                    name = "Латте",
                    water = 5,
                    coffee = 5,
                    milk = 10,
                    enteringCoins = 12
                }


            };

            Coffeemat coffeemat = new Coffeemat(reciepts);
            coffeemat.PrintCoffee();


        }

    }
}
