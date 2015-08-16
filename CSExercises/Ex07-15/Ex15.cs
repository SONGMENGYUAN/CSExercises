namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a three-digit integer: ");
            int a = System.Convert.ToInt32(System.Console.ReadLine());
            if((a>999) || (a<100))
            {
                System.Console.WriteLine("You enter a wrong number! ");
                return;
            }
            else
            {
                int i=a/100;
                int j=a%100/10;
                int k=a%10;
                if(a==i*i*i+j*j*j+k*k*k)
                {
                    System.Console.WriteLine("It is an Armstrong number!");
                }
                else
                {
                    System.Console.WriteLine("It isn't an Armstrong number!");
                }
            }
           
        }
    }
}