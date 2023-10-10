namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"The larger number is {a}!");
            }
            else if (a < b)
            {
                Console.WriteLine($"The larger number is {b}!");
            }
            else
            {
                Console.WriteLine("They are equal!");
            }
        }
    }
}
