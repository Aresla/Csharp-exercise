namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("It is even.");
            }
            else
            {
                Console.WriteLine("It is odd.");
            }
        }
    }
}
