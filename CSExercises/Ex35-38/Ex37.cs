using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string a = "institute of system science";
            string[] b = a.Split(' ');
            int i;
            string s = "";
            for(i=0;i<b.Length;i++)
            {
                string r = b[i];
                if (r.Length > 1)
                    r = r.ToUpper().Substring(0, 1) + r.Substring(1, r.Length - 1);
                s = s + r;
            Console.Write("{0} ",s);
            s = "";
            }
        }
    }
}
