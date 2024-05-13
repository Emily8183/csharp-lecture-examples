namespace Chapter05
{
    public class Book
    {
        // FIELDS

        private static int nextIdNum = 1;

        // Auto-implemented properties
        public string BookId { get; set; } // backing field is bookId
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
            BookId = GenerateBookId();
        }

        // Overloaded constructor to allow optional default value for numPages
        public Book(string title, string author)
            : this(title, author, 0) { }

        // OVERRIDE SPECIAL METHODS

        public override string ToString()
        {
            return "\n" + GetTitleAndAuthor() + "\n" + NumPages + " pages \nID " + BookId;
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
            Console.WriteLine("\n" + GetTitleAndAuthor() + " has been checked out of the library.");
        }

        public void CheckIn()
        {
            Available = true;
            Console.WriteLine("\n" + GetTitleAndAuthor() + " has been checked in.");
        }
    }
}
