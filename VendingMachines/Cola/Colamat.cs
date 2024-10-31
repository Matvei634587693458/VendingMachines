using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines.Cola
{
    class Colamat
    {
        public string machineName;

        public int colaAmount { get; set; }

        public int cashAmount { get; set; }

        private List<ColaReciept> _colaReciepts { get; set; }

        public Colamat(List<ColaReciept> reciepts)
        {
            colaAmount = ColaOptions.maxColaCoffeeAmount;
        }

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
        public void SellCola(int number, int personCash)
        {
            number--;

            if (number >= 0 && number < _colaReciepts.Count)
            {
                ColaReciept crnt = _colaReciepts[number];

                if (colaAmount >= crnt.cola)
                {
                    colaAmount -= crnt.cola;

                    personCash -= crnt.enteringCoins;

                    Console.WriteLine($"{crnt.colaname} готово");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
