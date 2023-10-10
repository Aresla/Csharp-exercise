namespace Exercise007
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where to?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where from?");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int x = b; x <= a; x++)
            {
                Console.WriteLine(x);
            }

        }
    }
}
