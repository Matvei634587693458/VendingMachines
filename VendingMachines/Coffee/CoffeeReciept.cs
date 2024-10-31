using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines.Coffee
{
    public class CoffeeReciept
    {
        public string name { get; set; }

        public int water { get; set; }

        public int coffee { get; set; }

        public int milk { get; set; }

        //public int sugar { get; set; }

        public int enteringCoins { get; set; }
    }
}
