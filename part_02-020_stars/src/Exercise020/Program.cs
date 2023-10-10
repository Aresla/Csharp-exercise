namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // you can print one star with the command
            // Console.Write("*");
            // call the print command n times
            // in the end print a line break with the comand
            // Console.WriteLine("");
            PrintTriangle(4);


        }

        //Write you methods here
        public static void PrintStars(int number)
        {
            while (number > 0)
            {
                Console.Write("*");
                number--;
            }
            Console.WriteLine("");
        }

        public static void PrintSquare(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(size);
            }

        }

        public static void PrintRectangle(int width, int height)
        {
            for (int i = 1; i <= height; i++)
            {
                PrintStars(width);
            }
        }

        public static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(i);
            }
        }
    }
}
