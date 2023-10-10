namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your speed:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 120)
            {
                Console.WriteLine("Speeding!");
            }
        }
    }
}
