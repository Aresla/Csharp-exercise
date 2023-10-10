namespace Exercise036
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else if (a > 0)
                {
                    Console.WriteLine(a * a);
                }
                else if (a < 0)
                {
                    Console.WriteLine("That is negative");
                }



            }
        }
    }
}
