using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int x;
            for (x = -4; x < 5; ++x)
            {
                int y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0}\t{1}",x,y);
            }
        }
    }
}
