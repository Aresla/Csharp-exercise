namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            double b = Convert.ToDouble(Console.ReadLine());
            double average = (a + b) / 2;
            Console.WriteLine($"The average is {average}");
        }
    }
}
