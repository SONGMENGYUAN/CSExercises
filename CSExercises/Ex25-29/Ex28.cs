using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int s = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    s = s + 1;
            }
                if ((s == 2) || (s == 1))
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not Prime");
        }
    }
}
