using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance of traveled in km : ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Ceiling(x * 10) / 10;
            if(y<0)
                 Console.WriteLine("You input wrong distance");
            if(y==0)
                 Console.WriteLine("The cost is 0");
            if((y>0)&&(y<=0.5))
                Console.WriteLine("The cost is $2.40");
            if((y>2.5)&&(y<=8.5))
                Console.WriteLine("The cost is ${0:0.00}",2.40+(y-0.5)*0.04);
            if(y>8.5)
                Console.WriteLine("The cost is ${0:0.00}", 2.40 + 8.5* 0.04+(y-9)*0.05);    
        }
    }
}