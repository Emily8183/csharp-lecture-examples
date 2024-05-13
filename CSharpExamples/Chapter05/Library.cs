namespace Chapter05
{
    public class Library
    {
        private List<Book> books = [];

        // Note: the default constructor is sufficient to instantiate a library object


        // OVERRIDE SPECIAL METHODS

        // TODO: Override ToString() to list the full collection of books
        // Use StringBuilder to loop over books and use their ToString() return value

        // TODO: Override Equals() and GetHashCode() - use Ctrl-. or Cmd-. to generate
        // Customize to do full checks for reference, null, and class before casting
        // Perform equality check on basis of title and author


        // INSTANCE METHODS

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // TODO: Add method to look up index of book using title and author

        public void PrintAvailableBooks()
        {
            Console.WriteLine("\nLIST OF BOOKS AVAILABLE:");
            foreach (Book book in books)
            {
                if (book.Available)
                {
                    Console.WriteLine("\t" + book.GetTitleAndAuthor());
                }
            }
        }
    }
}
