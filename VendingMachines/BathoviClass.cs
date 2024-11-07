namespace VendingMachines
{
    internal class BathoviClass
    {




        public void InputCash(int cashAmount, int PersonCash)
        {


            if (PersonCash > cashAmount)
            {
                Console.WriteLine($"Вот сдача {PersonCash}");
            }

        }

        public void ChangeCash(int cashAmount, int PersonCash)
        {
            if (PersonCash <= cashAmount)
            {
                PersonCash -= cashAmount;
                Console.WriteLine($"Вот сдача {PersonCash}");
            }

        }

        public void PrintMachine()
        {
            int count = 1;
            Console.WriteLine("Машина");
            foreach ( in _machin)
            {
                Console.WriteLine($"{count} {_machin.colaname}");
                count++;
            }


        }

    }
}
