namespace Chapter04
{
    public class Book
    {
        // FIELDS

        // Auto-implemented properties
        public string Title { get; set; } // backing field is title
        public string Author { get; set; } // author
        public int NumPages { get; set; } // numPages
        public bool Available { get; set; } = true; // available

        // CONSTRUCTORS

        public Book(string title, string author, int numPages)
        {
            Title = title;
            Author = author;
            NumPages = numPages;
        }

        // Overloaded constructor to allow optional default value for numPages
        public Book(string title, string author)
            : this(title, author, 0) { }

        // INSTANCE METHODS

        public string GetTitleAndAuthor()
        {
            return Title + " by " + Author;
        }

        public void CheckOut()
        {
            Available = false;
            Console.WriteLine("\n" + GetTitleAndAuthor() + " has been checked out of the library.");
        }

        public void CheckIn()
        {
            Available = true;
            Console.WriteLine("\n" + GetTitleAndAuthor() + " has been checked in.");
        }
    }
}
