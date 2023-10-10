namespace Exercise006
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 100;
            while (a <= count)
            {
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
