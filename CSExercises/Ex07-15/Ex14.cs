namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the lengths of three sides: a  b  c ");
            double a = System.Convert.ToDouble(System.Console.ReadLine());
            double b = System.Convert.ToDouble(System.Console.ReadLine());
            double c = System.Convert.ToDouble(System.Console.ReadLine());
            double S = (a+b+c)/2;
            double D = System.Math.Sqrt(S*(S-a)*(S-b)*(S-c));
            System.Console.WriteLine("AREA= {0}", D);
        }
    }
}