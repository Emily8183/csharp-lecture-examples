namespace Chapter04
{
    public class Book
    {
        // FIELDS

        // Encapsulation: keep relevant code together
        // Auto-implemented properties, field is still private but can access through getter and setter
        public string Title { get; set; } // backing field is title
        public string Author { get; set; } // author
        public int NumPages { get; set; } // numPages
        public bool Available { get; set; } = true; // available (as the default value)

        // CONSTRUCTORS

        public Book(string title, string author, int numPages) //the name of constructor must be the same as the class, no return type
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
            Console.WriteLine(Environment.NewLine + GetTitleAndAuthor() + " has been checked out of the library.");
        }

        public void CheckIn()
        {
            Available = true;
            Console.WriteLine(Environment.NewLine + GetTitleAndAuthor() + " has been checked in.");
        }
    }
}
