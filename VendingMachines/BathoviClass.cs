using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines
{
    internal class BathoviClass
    {
        public void InputCash(int cashAmount)
        {

            int PersonCash = Convert.ToInt32(Console.ReadLine());
            if (PersonCash > cashAmount)
            {
                Console.WriteLine($"Вот сдача {PersonCash}");
            }

        }

        public void ChangeCash(int cashAmount, int PersonCash)
        {

            PersonCash -= cashAmount;
            Console.WriteLine($"Вот сдача {PersonCash}");

        }

    }
}
