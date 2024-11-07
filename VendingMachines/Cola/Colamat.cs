using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines.Cola
{
    class Colamat
    {
        public string machineNameCOLA;

        public int colaAmount { get; set; }

        public int cashAmount { get; set; }

        private List<ColaReciept> _colaReciepts { get; set; }

        //Создает лист рецептов

        public Colamat(List<ColaReciept> reciepts)
        {
            colaAmount = ColaOptions.maxColaCoffeeAmount;
        }


        //Выводит напитки

        public void PrintCola()
        {
            int count = 1;
            Console.WriteLine("Кола");
            foreach (ColaReciept coLa in _colaReciepts)
            {
                Console.WriteLine($"{count} {coLa.colaname}");
                count++;
            }


        }

        // Просматривает ресурсы для продажи

        public void SellCola(int number)
        {
            number--;

            if (number >= 0 && number < _colaReciepts.Count)
            {
                ColaReciept crnt = _colaReciepts[number];

                if (colaAmount >= crnt.cola)
                {
                    colaAmount -= crnt.cola;

                    Console.WriteLine($"{crnt.colaname} готова");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
