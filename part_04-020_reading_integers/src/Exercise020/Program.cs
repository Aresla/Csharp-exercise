namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string imput = Console.ReadLine();
                if (imput == "end")
                {
                    break;
                }
                int number = Convert.ToInt32(imput);
                Console.WriteLine(Math.Pow(number, 3));
            }
        }
    }
}