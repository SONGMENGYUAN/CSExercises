using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int n;
            int i;
            int s = 0;
            for (n = 1; n <= 1000; n++)
            {
                for (i = 1; i < n; i++)
               {
                  if (n % i == 0)
                  s = s + i;
                }
                if (s == n)
                Console.WriteLine("{0},", n);
                s = 0;
                }
            }
        }
    }
