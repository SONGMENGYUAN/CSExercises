using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            for(int a=0;a<A.Length-1;a++)
            {
                for(int b=a+1;b<A.Length;b++)
                {
                    if (A[b] < A[a])
                    {
                        int temp = A[b];
                        A[b] = A[a];
                        A[a] = temp;
                        
                    for (int i = 0; i < A.Length; i++)
                   {
                       Console.Write("{0}\t", A[i]);
                   }
                    }
                    
                   
                  }
             } 
            
        }
    }
}
