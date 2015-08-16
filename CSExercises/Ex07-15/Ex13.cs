using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance of traveled: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2.4 + x * 0.4;
            Console.WriteLine("The total fare is ${0:0.00}", y);
            double a =Math.Floor(y*10)/10;
            if(y>a)
            {
                Console.WriteLine("Rounded up: {0:0.00}", a + 0.1);
            }
            else
            {
                Console.WriteLine("Rounded up: {0:0.00}", a);
            }
        }
    }
}
