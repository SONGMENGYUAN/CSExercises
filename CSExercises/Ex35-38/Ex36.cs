using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string r = Console.ReadLine();
            int i = r.Length;
            int j;
            int s = 0;
            for( j=0;j<i/2; j++)
            {
                if (r[j] != r[i - j - 1])
                {
                    Console.WriteLine("Not Palindrome");
                    break;
                }
                s = s + 1;
            } 
            if(s!=0)
                Console.WriteLine("Palindrome"); 
            }

        }
    }
