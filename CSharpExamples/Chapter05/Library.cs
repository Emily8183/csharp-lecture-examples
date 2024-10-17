using System.Text;

namespace Chapter05
{
    public class Library
    {
        private readonly List<Book> books = [];

        // Note: the default constructor is sufficient to instantiate a library object

        // OVERRIDE SPECIAL METHODS

        public override string ToString()
        {
            string nl = Environment.NewLine;
            StringBuilder allBookInfo = new();
            foreach (Book book in books)
            {
                allBookInfo.Append(book); // implicit call to .ToString()
                allBookInfo.Append(nl + Constants.DASHED_LINE);
            }
            return nl + "WELCOME TO OUR LIBRARY!" + nl + nl
                + "View our full collection:" + nl
                + Constants.DASHED_LINE
                + allBookInfo; // implicit converstion to string
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
            if (books.Count != otherLibrary.books.Count)
            {
                return false;
            }

            // Custom comparison of contents
            foreach (Book book in books)
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
            //NotImplementedException is a way to signal that the method is not yet implemented. 
            //When this code runs, it will throw an exception to indicate that GetHashCode() hasn't been provided with any meaningful logic yet.
        }

        // here's another sample, two objects with the same Name and Price will generate the same hash code.
        // public override int GetHashCode()
        // {
        //     return HashCode.Combine(Name, Price);  // Combine important properties for uniqueness
        // }
        
        // INSTANCE METHODS

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public int FindBook(string title, string author)
        {
            foreach (Book book in books)
            {
                if (Equals(book.Title, title) && Equals(book.Author, author))
                {
                    return books.IndexOf(book);
                }
            }
            return -1;
        }

        public void PrintAvailableBooks()
        {
            Console.WriteLine(Environment.NewLine + "LIST OF BOOKS AVAILABLE:");
            foreach (Book book in books)
            {
                if (book.Available)
                {
                    Console.WriteLine(book.GetTitleAndAuthor());
                }
            }
        }
    }
}
