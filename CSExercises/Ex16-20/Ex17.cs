using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name, gender(M/F) and age:");
            string n = Console.ReadLine();
            string x = Console.ReadLine();
            int a = Convert.ToInt32(Console.ReadLine());
            if (x == "M")
                if (a >= 40)
                {
                    Console.WriteLine("Good Morning Uncle " + n);
                }
                
                else
                    Console.WriteLine("Good Morning Mr."+n);
            if (x == "F") 
                if(a>=40)
                {
                    Console.WriteLine("Good Morning Aunty " + n);
                }
                else
                    Console.WriteLine("Good Morning Ms." + n);
        }
    }
}