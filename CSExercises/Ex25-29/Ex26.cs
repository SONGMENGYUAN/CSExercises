using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double j;
            for (j = 1; j <=10; j++)
            {
                Console.WriteLine("inverse is:{0}", 1/j);
                Console.WriteLine("Square root is:{0}", Math.Sqrt(j));
                Console.WriteLine("Square is :{0}", j * j);
            }
        }
    }
}
