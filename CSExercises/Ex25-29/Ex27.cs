using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int x;
            for (x = 1; x <= 20; ++x)
            {
                int y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0}\t{1}", x, y);
            } 
            for (x = 1; x <= 20; ++x)
            {
                int y = 2 * x * x - 4 * x + 3;
                for (int i = 0; i < y; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
