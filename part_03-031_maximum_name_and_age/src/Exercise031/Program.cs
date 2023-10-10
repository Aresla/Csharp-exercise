namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int birthYear = 0;
            int highestAge = 0;
            string name = "";
            string longestName = "";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pieces = input.Split(",");
                birthYear = Convert.ToInt32(pieces[1]);
                int age = 2023 - birthYear;
                name = pieces[0];
                if (name.Length > longestName.Length)
                {
                    longestName = name;
                }
                if (age > highestAge)
                {
                    highestAge = age;
                }
            }
            Console.WriteLine("Longest name: " + longestName);
            Console.WriteLine("Highest age: " + highestAge);
        }
    }
}