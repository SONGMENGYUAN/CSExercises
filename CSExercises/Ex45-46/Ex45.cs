using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.Write("Input an amount: ");
            double n = Convert.ToDouble(Console.ReadLine());
            if ((n<0.05) && (n > 3.50))
            {
                Console.Write("Error");
                return;
            }
            double a = n * 100;
            if (a % 5 != 0)
            {

                Console.Write("Error");
                return;
            }
            while (a >= 100)
            {
                Console.WriteLine("100c");
                a = a - 100;
            }
            if (a >= 50)
            {
                Console.WriteLine("50c");
                a = a - 50;
            }
             while (a >= 20)
                {
                    Console.WriteLine("20c");
                    a = a - 20;
                }
                if (a >= 10)
                {
                    Console.WriteLine("10c");
                    a=a-10;
                }
                    if (a == 5)
                    {
                        Console.WriteLine("5c");

                    }
                }
            }
        }

