using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int secretNumber = r.Next(0, 10);
            int guess;
            int i=0;
            do
            {
                Console.Write("Enter a guess(0-9):");
                guess = Convert.ToInt32(Console.ReadLine());
                i = i + 1;
                if (guess != secretNumber)
                {
                    Console.WriteLine("Try again!");
                }
                else
                {
                    Console.WriteLine("Your attempts are{0}", i);
                    if (i <= 2)
                        Console.WriteLine("You are a Wizard! ");
                    if ((i > 2) && (i <= 5))
                        Console.WriteLine("You are a good guess");
                    if ((i > 5) && (i == 0))
                        Console.WriteLine("You are lousy!");
                }
            } while (guess!=secretNumber); 
            }
            
    }
}
