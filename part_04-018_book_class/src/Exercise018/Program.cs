namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // implement here the program that allows the user to enter 
            // book information and to examine them
            List<Book> list = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string title = Console.ReadLine();

                if (title == "")
                {
                    Console.Write("\n");
                    break;
                }

                Console.Write("Pages: ");
                int numberOfPages = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publication year: ");
                int publicationYear = Convert.ToInt32(Console.ReadLine());

                list.Add(new Book(title, numberOfPages, publicationYear));
            }
            Console.Write("What information will be printed? ");
            string input = Console.ReadLine();
            if (input == "everything")
            {
                foreach (Book book in list)
                {
                    Console.Write(book.ToString());
                    Console.WriteLine();
                }
            }
            else if (input == "title")
            {
                foreach (Book book in list)
                {
                    Console.Write(book.title);
                    Console.WriteLine();
                }
            }

        }
    }
}