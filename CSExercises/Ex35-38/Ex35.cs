using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string r = Console.ReadLine();
            int i;
            int s=0;
            int Sa = 0;
            int Sb = 0;
            int Sc = 0;
            int Sd = 0;
            int Se = 0;
            for(i=0;i<r.Length;i++)
            {
                if (r[i] == 'a' || r[i] == 'e' || r[i] == 'i' || r[i] == 'o' || r[i] == 'u')
                    s = s + 1;
                if (r[i] == 'a')
                    Sa = Sa + 1;
                if (r[i] == 'e')
                    Sb= Sb + 1;
                if (r[i] == 'i')
                    Sc= Sc + 1;
                if (r[i] == 'o')
                    Sd = Sd + 1;
                if (r[i] == 'u')
                    Se = Se + 1;
            }
            Console.WriteLine("Total number of vowels:{0}", s);
            Console.WriteLine("Number of a:{0}", Sa);
            Console.WriteLine("Number of e:{0}", Sb);
            Console.WriteLine("Number of i:{0}", Sc);
            Console.WriteLine("Number of o:{0}", Sd);
            Console.WriteLine("Number of u:{0}", Se);
        }
    }
}
