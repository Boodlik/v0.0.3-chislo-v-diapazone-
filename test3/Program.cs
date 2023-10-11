using System.ComponentModel.Design;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 5;
            int z = 10;

            if (x >= y && x <= z)
            {
                Console.WriteLine($"Число {x} gопадает в диапозон ");
            }
            else
                if (x < y)
            {
                Console.WriteLine($"Число {x} не попадает в диапазон ");
            }
            else
                if (x > z)
            {
                Console.WriteLine($"Число {x} не попадает в диапазон ");
            }
            else;
        }
    }
}