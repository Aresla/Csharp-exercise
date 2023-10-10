namespace Exercise035
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
                if (a == 42)
                {
                    break;
                }

            }

        }
    }
}
