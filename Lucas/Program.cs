using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);

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
