using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int n;
            int i;
            int s = 0;
            for (n = 5; n <= 10000;n++ )
            {
                for (i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        s = s + 1;
                }
                if (s == 2) 
                    Console.Write("{0},", n);
                s = 0;
            } 
        }
    }
}
