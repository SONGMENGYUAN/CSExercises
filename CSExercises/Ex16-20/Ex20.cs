using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter quantity for TV: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            int z = Convert.ToInt32(Console.ReadLine()); 
            int s = x*900+y*500;
            if ((s>=5000)&&(s<10000))
                Console.WriteLine("Total price for this order is ${0}",s*0.9+700*z);
            if (s>=10000)
                Console.WriteLine("Total price for this order is ${0}", s * 0.85 + 700 * z);
            if(s<5000)
                Console.WriteLine("Total price for this order is ${0}", s + 700 * z);
        }
    }
}00
