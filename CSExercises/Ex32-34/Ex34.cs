using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {

            int[,] score = new int[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            double s = 0;
            int i;
            int j;
            double m = 0;
            for (i = 0; i < 12; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    s = s + score[i, j];
                    Console.Write(score[i, j] + "\t");
                }
                Console.WriteLine(s);
                s = 0;
            }
            Console.WriteLine();
            for (j = 0; j < 4; j++)
            {
                for (i = 0; i < 12; i++)
                {
                    s = s + score[i, j];
                }
                Console.WriteLine("Class average of {0} subject:{1:0.00}", j, s / 12);


                for (i = 0; i < 12; i++)
                {
                    m = (score[i, j] - s / 12) * (score[i, j] - s / 12) + m;
                }
                Console.WriteLine("The standard deviation of{0} subject:{1}", j, Math.Sqrt(m / 12));
                m = 0;
                s = 0;
            }
            for (i = 0; i < 12; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    s = s + score[i, j];
                }
            }
            Console.WriteLine("Overall average is{0:0.00}", s / 48);
        }
    }
}
