using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number:");
            int N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int S = r.Next(1, N + 1);
            double G = S;
            if (G * G == N)
                Console.WriteLine("The square root of the number:{0}", G);
            else
            {
                while (Math.Abs(N - G * G) >=0.00001)
                {
                    G = (G + N / G) / 2;
                }
                Console.WriteLine("The square root of the number:{0}", G);
            }
        }
    }
}
