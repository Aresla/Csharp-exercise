namespace Exercise004
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}.");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a} is less than {b}.");
            }
            else
            {
                Console.WriteLine($"{a} is equal to {b}.");
            }
        }
    }
}
