namespace Exercise018
{
    using System;
    public class Book
    {

        public string title { get; }
        public int numberOfPages { get; set; }
        public int publicationYear { get; set; }


        public Book(string title, int numberOfPages, int publicationYear)
        {
            this.title = title;
            this.numberOfPages = numberOfPages;
            this.publicationYear = publicationYear;
        }

        public override string ToString()
        {
            return this.title + ", " + this.numberOfPages + " pages" + ", " + this.publicationYear;
        }
    }
}