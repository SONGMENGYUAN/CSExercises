using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            double[] month = new double[12];
            int i;
            double max = 0;
            double min = 0;
            int a =0;
            int b = 0;
            double S = 0;
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter sales for month {0}:", i);
                month[i] = Convert.ToDouble(Console.ReadLine());
                S = S + month[i];
                if (min == 0)
                    min = month[0];
                if (min > month[i])
                {
                    min = month[i];
                    a = i;
                }
                    if (max == 0)
                        max = month[0];
                    if (max < month[i])
                    {
                        max = month[i];
                        b = 0 + i;

                    }
           }
                    Console.WriteLine("MinMonth:{0}", a);
                    Console.WriteLine("MaxMonth:{0}", b);
                    Console.WriteLine("Average sales:{0}", S / 12);


                }
            }
        }