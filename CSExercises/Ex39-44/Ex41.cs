using System;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            int n = s1.Length;
            int a=0;
            for (int i = 0; i < n - s2.Length;i++ )
            {
                string s3 = s1.Substring(i, s2.Length);
                a = s3.CompareTo(s2);
            }
            if (a != 0)
                return false;
            else
                return true;
        }
    }
}
