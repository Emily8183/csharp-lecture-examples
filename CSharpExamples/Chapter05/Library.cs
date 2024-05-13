using System.Text;

namespace Chapter05
{
    public class Library
    {
        private List<Book> Books { get; } = [];

        // Note: the default constructor is sufficient to instantiate a library object

        // OVERRIDE SPECIAL METHODS

        public override string ToString()
        {
            StringBuilder allBookInfo = new();
            foreach (Book book in Books)
            {
                allBookInfo.Append(book.ToString());
                allBookInfo.Append("\n" + Constants.DASHED_LINE);
            }
            return "\nWELCOME TO OUR LIBRARY!\n\n"
                + "View our full collection:\n"
                + Constants.DASHED_LINE
                + allBookInfo; // stringified automatically
        }

        public override bool Equals(object? toBeCompared)
        {
            // Reference check
            if (this == toBeCompared)
            {
                return true;
            }

            // Null check
            if (toBeCompared == null)
            {
                return false;
            }

            // Class check
            if (GetType() != toBeCompared.GetType())
            {
                return false;
            }

            // Cast
            Library otherLibrary = (Library)toBeCompared;

            // Compare size of lists first
            if (Books.Count != otherLibrary.Books.Count)
            {
                return false;
            }

            // Custom comparison of contents
            foreach (Book book in Books)
            {
                int index = otherLibrary.FindBook(book.Title, book.Author);
                if (index == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        // INSTANCE METHODS

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public int FindBook(string title, string author)
        {
            foreach (Book book in Books)
            {
                if (Equals(book.Title, title) && Equals(book.Author, author))
                {
                    return Books.IndexOf(book);
                }
            }
            return -1;
        }

        public void PrintAvailableBooks()
        {
            Console.WriteLine("\nLIST OF BOOKS AVAILABLE:");
            foreach (Book book in Books)
            {
                if (book.Available)
                {
                    Console.WriteLine("\t" + book.GetTitleAndAuthor());
                }
            }
        }
    }
}
