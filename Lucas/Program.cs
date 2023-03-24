using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int resultado = Lucas(n);
            Console.WriteLine($"the {n} number of the Lucas sequence is: {resultado}");
        }

        private static int Lucas(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Lucas(n - 1) + Lucas(n - 2);
            }
        }
    }
}
