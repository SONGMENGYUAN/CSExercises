using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = { 63, 29, 75, 82, 55 };
            int a;
            int b;
            for (a = 0; a < marks.Length - 1; a++)
            {
                for (b = a + 1; b < marks.Length; b++)
                {
                    if (marks[b] < marks[a])
                    {
                        int temp = marks[b];
                        marks[b] = marks[a];
                        marks[a] = temp;
                        string temp2 = name[b];
                        name[b] = name[a];
                        name[a] = temp2;
                    }
                }
            }
            Console.WriteLine("Name\tMarks");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(name[i] + "\t" + marks[i]);
            }
            for (a = 0; a < marks.Length - 1; a++)
            {
                for (b = a + 1; b < marks.Length; b++)
                {
                    if (name[a].CompareTo(name[b]) == 1)
                    {
                        int temp = marks[b];
                        marks[b] = marks[a];
                        marks[a] = temp;
                        string temp2 = name[b];
                        name[b] = name[a];
                        name[a] = temp2;
                        
                    }
                }
            } 
            Console.WriteLine("Name\tMarks");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(name[i] + "\t" + marks[i]);
            }
        }
    }
}
