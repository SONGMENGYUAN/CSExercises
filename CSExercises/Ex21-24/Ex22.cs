using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter B:");
            int B = Convert.ToInt32(Console.ReadLine());
            int a=A;
            int b=B;
            do
            {
                if(a >b)
                a = a - b;
                else
                b = b - a;
            }
            while (a!= b);
            Console.WriteLine("HCF: {0}", a);
            Console.WriteLine("LCM: {0}", (A * B) / a);
        }
    }
}
