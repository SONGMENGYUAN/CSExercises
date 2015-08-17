using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and gender(M/F)");
            string n = Console.ReadLine();
            string x = Console.ReadLine();
            if (x == "M")
                Console.WriteLine("Good Morning Mr." + n);

            else
                Console.WriteLine("Good Morning Ms." + n);
        }
    }
}