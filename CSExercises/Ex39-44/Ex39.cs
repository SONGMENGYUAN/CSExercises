using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            long n = Convert.ToInt32(Console.ReadLine());
            long a = Factorial(n);
            Console.Write(a);
        }
        public static long Factorial(long n)
        {  
            int i;
            long x=0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i+"\t");   
            } 
            x = Convert.ToInt32(Console.ReadLine());
            return x; 
        }
    }
}
