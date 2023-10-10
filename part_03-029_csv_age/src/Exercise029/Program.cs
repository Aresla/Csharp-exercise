namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] pieces = input.Split(",");

                int age = Convert.ToInt32(pieces[1]);
                if (age > oldest)
                {
                    oldest = age;
                }
            }
            Console.WriteLine("Age of the oldest: " + oldest);

        }
    }
}