namespace Exercise037
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine($"Total amount of numbers: {count}");
                    break;
                }
                count++;
            }
        }
    }
}
