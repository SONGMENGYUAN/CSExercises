using System;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.Write("Take an word: ");
            string s=Console.ReadLine();
            Console.Write("Take an charactor: ");
            char c1= Convert.ToChar(Console.ReadLine());
            Console.Write("Take an charactor: ");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Substitute(s,c1 ,c2 )); 
        }
        public static string Substitute(string s, char c1, char c2)
        {
            int i;
            int counter = 0;
            string s2="";
            for(i=0;i<s.Length-1 ;i++)
            {
                if(c1==s[i])
                {
                    counter=counter+1;
                    s2=s2+c2;
                }
                else
                    s2=s2+c1;
                }
            return s2;
        } 
    }
}
