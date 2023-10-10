namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string a = Console.ReadLine();

            Console.WriteLine("Give an integer:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give a double:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give a boolean:");
            Boolean d = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"Your string: {a}");
            Console.WriteLine($"Your integer: {b}");
            Console.WriteLine($"Your double: {c}");
            Console.WriteLine($"Your boolean: {d}");
        }
    }
}
