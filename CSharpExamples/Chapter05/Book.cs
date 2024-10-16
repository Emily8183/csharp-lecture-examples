namespace Chapter05
{
    public class Book
    {
        // FIELDS

        private static int nextIdNum = 1;
        public readonly string bookId; // Value set in constructor, Assigned only once in constructor. same as Java's "final"

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
            bookId = GenerateBookId(); // Assigns a unique ID internally, so we dont need to involve bookId in parameter
        }

        // Overloaded constructor to allow optional default value for numPages
        public Book(string title, string author)
            : this(title, author, 0) { }

        // OVERRIDE SPECIAL METHODS

        public override string ToString()
        {
            string nl = Environment.NewLine;
            return nl + GetTitleAndAuthor() + nl + NumPages + " pages" + nl + "ID " + bookId;
        }

        // INSTANCE METHODS

        private string GenerateBookId()
        {
            string id =
                Utils.GetInitials(Author) + "-" + Title.Substring(0, 3).ToUpper() + "-" + nextIdNum;
            nextIdNum++;
            return id;
        }

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
