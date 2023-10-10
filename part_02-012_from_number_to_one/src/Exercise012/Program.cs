namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            PrintFromNumberToOne(num);
        }
        public static void PrintFromNumberToOne(int num)
        {
            while (num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
        }

    }

}








