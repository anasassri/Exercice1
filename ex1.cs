using System.Collections.Generic;


namespace EXERCICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1;
            do
            {
                Console.WriteLine("Entrer un nombre:");
                N1 = Convert.ToInt32(Console.ReadLine());
            } while (N1 <= 0);
            if (IsPrim(N1)) { Console.WriteLine("est premier"); }
            else
            {
                Console.WriteLine("Pas Premier");
            }
            Console.ReadLine();
        }
        public static bool IsPrim(int num)
        {
            bool isPrim = true;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrim = false;

                }
            }
            return isPrime;
        }
    }
}