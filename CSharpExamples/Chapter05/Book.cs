namespace Chapter05
{
    public class Book
    {
        // FIELDS

        // TODO: Add a class-level field for tracking next available Id number

        // Auto-implemented properties
        // TODO: Add a BookId property
        public string Title { get; set; } // title
        public string Author { get; set; } // author
        public int NumPages { get; set; } // numPages
        public bool Available { get; set; } = true; // available


        // CONSTRUCTORS

        public Book(string title, string author, int numPages)
        {
            Title = title;
            Author = author;
            NumPages = numPages;
            // TODO: set BookId using instance method to concatenate string
        }

        // Overloaded constructor to allow optional default value for numPages
        public Book(string title, string author)
            : this(title, author, 0) { }


        // OVERRIDE SPECIAL METHODS

        // TODO: Override ToString() to include title, author, number of pages, and book id


        // INSTANCE METHODS

        // TODO: Write a method to generate a book ID with initials, title, and next ID num
        // Remember to increase next Id num for next book

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
