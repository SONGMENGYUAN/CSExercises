using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int s = 0;
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                s = s + i;
                }
                if (s == n)
                    Console.WriteLine("Perfect Number");
                else
                    Console.WriteLine("Not Perfect Number");

        }
    }
   }
