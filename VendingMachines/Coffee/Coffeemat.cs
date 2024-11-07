using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines.Coffee
{
    internal class Coffeemat
    {
        public string machineNameCOFFEE;
        public int waterAmount { get; set; }

        public int coffeeAmount { get; set; }

        public int milkAmount { get; set; }

        public int cashAmount { get; set; }

        private List<CoffeeReciept> _coffeeReciepts { get; set; }

        //Создает лист рецептов


        public Coffeemat(List<CoffeeReciept> reciepts)
        {
            waterAmount = CoffeeOptions.maxWaterCoffeeAmount;
            coffeeAmount = CoffeeOptions.maxCoffeeCoffeeAmount;
            milkAmount = CoffeeOptions.maxMilkCoffeeAmount;
        }

        //Выводит напитки

        public void PrintCoffee()
        {
            int count = 1;
            Console.WriteLine("Кофеечек");
            foreach (CoffeeReciept coFFee in _coffeeReciepts)
            {
                Console.WriteLine($"{count} {coFFee.name}");
                count++;
            }


        }


        // Просматривает ресурсы для продажи
        public void SellCoffee(int number)
        {
            number--;

            if (number >= 0 && number < _coffeeReciepts.Count)
            {
                CoffeeReciept crnt = _coffeeReciepts[number];

                if (waterAmount >= crnt.water && coffeeAmount >= crnt.water && milkAmount >= crnt.water)
                {
                    waterAmount -= crnt.water;
                    coffeeAmount -= crnt.coffee;
                    milkAmount -= crnt.milk;

                    Console.WriteLine($"{crnt.name} готово");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}












