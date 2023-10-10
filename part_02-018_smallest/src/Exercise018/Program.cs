namespace Exercise018
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here:
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int answer = Smallest(number1, number2);
            Console.WriteLine("Smallest: " + answer);
        }
        //Write your method here:
        public static int Smallest(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}
