using System;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            int j;
            for(j=1;j<=100;j++)
            {
               string x=Hex(j);
                Console.Write(x+"\t");
            }
        }
        public static string Hex(int i)
        {
            char[] hex = { '0', '1','2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
           int temp=i;
           int a=temp/16;
           string e = "";
               e = Convert.ToString(a) + hex[temp % 16];
           return e;   
        }
    }
}
