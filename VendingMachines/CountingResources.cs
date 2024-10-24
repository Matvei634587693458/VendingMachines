namespace VendingMachines
{
    public class CountingResources
    {

        public static string eatsPoins(double cash, double water, double coffee, double milk)
        {

            Console.WriteLine("Сколько человечек вводит денешек");
            double enteringCoins = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Загораются три кнопки Американо(Введите 1), Капучино(Введите 2), Латте(Введите 3)");
            string OrderSelection = Console.ReadLine();

            if (OrderSelection == "1" && cash > enteringCoins && water >= 101 && coffee >= 101)
            {
                OrderSelection = "Американо";
            }

            else if (OrderSelection == "2" && cash > enteringCoins && water >= 101 && coffee >= 101 && milk >= 101)
            {
                OrderSelection = "Капучино";
            }

            else if (OrderSelection == "3" && cash > enteringCoins && water >= 101 && coffee >= 101 && milk >= 201)
            {
                OrderSelection = "Латте";
            }

            else
            {
                OrderSelection = "Недостает компонентов";
                Console.WriteLine("Автомат выдает монетки");
            }

            return OrderSelection;

        }

        public static string Purchase(string OrderSelection, double water, double coffee, double milk)
        {

            if (OrderSelection == "Американо")
            {
                water -= 101;
                coffee -= 101;
            }

            else if (OrderSelection == "Капучино")
            {
                water -= 101;
                coffee -= 101;
                milk -= 101;
            }

            else if (OrderSelection == "Латте")
            {
                water -= 101;
                coffee -= 101;
                milk -= 201;
            }

            return "Налили кофиёчек";

        }

        public static double PouredSugar(double sugar)
        {

            Console.WriteLine("Загорается кнопочка насыпать сахар и не насыпать ( насыпать (1) / не насыпать (2) )");
            double ChoosingSugar = Convert.ToInt32(Console.ReadLine());

            if (ChoosingSugar == 1)
            {
                sugar -= 101;
            }

            else
            {
                Console.WriteLine("Не хочешь как хочешь");
            }

            return ChoosingSugar;

        }

        public static double Change(double ChoosingSugar, string OrderSelection, double cash, double enteringCoins)
        {

            double sum = 0;

            if (ChoosingSugar == 1)
            {
                sum += enteringCoins;
            }

            if (OrderSelection == "Американо")
            {
                sum += 100;
            }

            if (OrderSelection == "Капучино")
            {
                sum += 200;
            }

            if (OrderSelection == "Латте")
            {
                sum += 300;
            }

            cash += sum;

            enteringCoins -= sum;
            Console.WriteLine($"Челик колучат столько монеток {enteringCoins}");

            return cash;
        }


    }
}
