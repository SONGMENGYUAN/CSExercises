using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a number");
              int i=Convert.ToInt32( Console.ReadLine());
              int j;
              int m=1;
            for(j=i;j=1;j--)
            {
                m = m * j;
            }
            Console.WriteLine("Its factorial is{0}", m);
        }
    }
}
