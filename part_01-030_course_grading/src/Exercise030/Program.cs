namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your percent [0 - 100]:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (a >= 0 && a <= 49)
            {
                Console.WriteLine("Fail");
            }
            else if (a >= 50 && a <= 59)
            {
                Console.WriteLine("Grade: 1");
            }
            else if (a >= 60 && a <= 69)
            {
                Console.WriteLine("Grade: 2");
            }
            else if (a >= 70 && a <= 79)
            {
                Console.WriteLine("Grade: 3");
            }
            else if (a >= 80 && a <= 89)
            {
                Console.WriteLine("Grade: 4");
            }
            else if (a >= 90 && a <= 100)
            {
                Console.WriteLine("Grade: 5");
            }
            else if (a > 100)
            {
                Console.WriteLine("Outstanding!");
            }
        }
    }
}
