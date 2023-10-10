namespace Exercise027
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("It is positive");
            }
            else
            {
                Console.WriteLine("It is not positive");
            }
        }
    }
}




