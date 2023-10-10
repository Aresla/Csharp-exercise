namespace Exercise010
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Write your code here
            Console.WriteLine("How many times?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            while (howMany > 0)
            {
                PrintPhrase();
                howMany--;
            }
        }
        //Write your method here
        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }
    }
}
