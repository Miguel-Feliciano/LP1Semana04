using System;

namespace Power2Method
{
    /// <summary>
    /// In this program, the player can invoke one of two methods that will 
    /// display the powers bit by bit of a given number
    /// </summary>
    class Program
    {
        /// <summary>
        /// Where all methods are called and executed
        /// </summary>
        /// <param name="args">an array of strings</param>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
            PowersOf2UntilN(7);
            PowersOf2UntilN(3, 6);
        }
        /// <summary>
        /// Calls PowersOf2UntilN with the value of 5
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }
        /// <summary>
        /// Prints the powers bit by bit of the given number
        /// </summary>
        /// <param name="n">the number of times to calculate the powers</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Imprime as potências de 2 entre as n1 e n2
        /// </summary>
        /// <param name="n1">A potência mínima a ser exibida.</param>
        /// <param name="n2">A potência máxima a ser exibida.</param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = (1 << n1); i <= (1 << n2); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
