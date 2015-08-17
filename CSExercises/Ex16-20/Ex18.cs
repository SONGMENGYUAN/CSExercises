using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your mark:");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a<0)||(a>100))
                Console.WriteLine("You scored {0}marks which is **Error**");
            else
                if((a>=80)&&(a<=100))
                      Console.WriteLine("You scored {0}marks which is A",a);
                if ((a >= 60)&&(a<=79))
                     Console.WriteLine("You scored {0}marks which is B",a);
                if((a >=40)&&(a<=59))
                     Console.WriteLine("You scored {0}marks which is C",a);
                if ((a >= 0) && (a <= 39))
                Console.WriteLine("You scored {0}marks which is F",a);
                
        }
    }
}