namespace Exercise028
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("You're an adult!");
            }
            else
            {
                Console.WriteLine("You're under age!");
            }
        }
    }
}
