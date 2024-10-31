using System.Drawing;
using VendingMachines.Coffee;
using VendingMachines.Cola;

namespace VendingMachines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CoffeeReciept> cofreciepts = new List<CoffeeReciept>()
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
            List<ColaReciept> colreciepts = new List<ColaReciept>()
            {
                new ColaReciept()
                {
                    colaname = "Соса сола",
                    cola = 3,
                    enteringCoins = 5
                },
                new ColaReciept()
                {
                    colaname = "Спрайт",
                    cola = 1,
                    enteringCoins = 10
                },
                new ColaReciept()
                {
                    colaname = "Буратино",
                    cola = 5,
                    enteringCoins = 12
                }


            };

            Colamat colamat = new Colamat(colreciepts);
            colamat.PrintCola();

            Coffeemat coffeemat = new Coffeemat(cofreciepts);
            coffeemat.PrintCoffee();

        }

    }
}
