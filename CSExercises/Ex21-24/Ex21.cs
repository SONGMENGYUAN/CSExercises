using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int secretNumber = 88;
            bool shouldStop = false;
            while (!shouldStop)
            {
                Console.Write("Please enter an inter number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("Lucky you...");
                    shouldStop = true;
                }
                
            }
         }
    }
}
