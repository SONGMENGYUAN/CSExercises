using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
           Console.Write("Take the salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total income is ${0:0.00}", salary*1.13);  
        }
    }
}

