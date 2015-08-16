using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.Write("Take an number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square is {0}", Math.Sqrt(number));  
        }
    }
}
