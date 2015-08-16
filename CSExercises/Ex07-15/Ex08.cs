using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a temperature in Centigrade: ");
            double C = Convert.ToDouble(Console.ReadLine());
            double F =1.8*C+32;
            Console.WriteLine("Convert to Fahrenheit {0}", F);   
        }
    }
}
