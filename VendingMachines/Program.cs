using VendingMachines.Coffee;
using VendingMachines.Cola;

namespace VendingMachines
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Создание рецептов

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




            Console.WriteLine("Выберите автомат cola(1)/coffee(2)");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Colamat colamat = new Colamat(colreciepts);
                colamat.PrintCola();
                int number = Convert.ToInt32(Console.ReadLine());
                colamat.SellCola(number);
                int PersonCash = Convert.ToInt32(Console.ReadLine());
                BathoviClass.InputCash(cashAmount, PersonCash);
                BathoviClass.ChangeCash(cashAmount, PersonCash);
            }
            if (choice == 2)
            {
                Coffeemat coffeemat = new Coffeemat(cofreciepts);
                coffeemat.PrintCoffee();
                int number = Convert.ToInt32(Console.ReadLine());
                coffeemat.SellCoffee(number);
                int PersonCash = Convert.ToInt32(Console.ReadLine());
                BathoviClass.InputCash(cashAmount, PersonCash);
                BathoviClass.ChangeCash(cashAmount, PersonCash);
            }







        }

    }
}
