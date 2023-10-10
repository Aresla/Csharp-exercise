namespace Exercise040
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine($"Total sum of numbers: {sum}");
                    Console.WriteLine($"Total amount of numbers: {count}");
                    break;
                }
                sum += a;
                count++;
            }
        }
    }
}
