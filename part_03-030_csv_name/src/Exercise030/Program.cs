namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            string nameOfTheOldest = "";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] pieces = input.Split(",");

                int age = Convert.ToInt32(pieces[1]);
                string name = pieces[0];
                if (age > oldest)
                {
                    oldest = age;
                    nameOfTheOldest = name;
                }
            }
            Console.WriteLine("Name of the oldest: " + nameOfTheOldest);
        }
    }
}