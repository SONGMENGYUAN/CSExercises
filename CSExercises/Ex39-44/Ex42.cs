 namespace CSExercises
{
    public class Ex42
    {

        public static int FindWord(string s1, string s2)
        {
          
            int n = s1.Length;
            int a=0;
            for (int i = 0; i < n - s2.Length;i++ )
            {
                string s3 = s1.Substring(i, s2.Length);
                a = s3.CompareTo(s2);
            }
            if (a != 0)
                return 0;
            else
                return -1;
        }
    }
}
