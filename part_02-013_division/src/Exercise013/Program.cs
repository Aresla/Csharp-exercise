namespace Exercise013
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here
            int numerator = Convert.ToInt32(Console.ReadLine());
            int denominator = Convert.ToInt32(Console.ReadLine());
            Division(numerator, denominator);
        }
        //Write your method here
        public static void Division(int numerator, int denominator)
        {
            Console.WriteLine(Convert.ToDouble(numerator) / Convert.ToDouble(denominator));
        }
    }
}
