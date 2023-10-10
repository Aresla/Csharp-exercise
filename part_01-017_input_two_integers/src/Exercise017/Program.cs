namespace Exercise017
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
            int sum = a + b;
            Console.WriteLine($"The sum is {sum}");
        }
    }
}