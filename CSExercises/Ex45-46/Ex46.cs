using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int [] a = new int[50];
            int[]c=new int[]{0,1,2,3,4,5,6,7,8,9};
            int i;
            int j=0;
            int[]b=new int[]{0,0,0,0,0,0,0,0,0,0};
            Random r = new Random();
            for(i=0;i<50;i++)
            {
                 a[i] = r.Next(0, 10);
               for(j=0;j<10;j++)
               {
                   if(a[i]==j)
                   {
                       b[j] = b[j] + 1;
                   }
               }
            }
            Console.WriteLine("Number\tCounter");
            for(int x=0;x<10;x++)
            {
                Console.WriteLine(c[x] + "\t" + b[x]);
            }
        }
    }
}
