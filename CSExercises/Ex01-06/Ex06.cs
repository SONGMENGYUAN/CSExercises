using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Take an integer: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square root is {0}",Math.Sqrt(integer));  
        }
    }
}
