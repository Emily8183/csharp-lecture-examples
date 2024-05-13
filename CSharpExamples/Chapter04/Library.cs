namespace Chapter04
{
    public class Library
    {
        private List<Book> Books { get; } = [];

        // Note: the default constructor is sufficient to instantiate a library object

        // INSTANCE METHODS

        public void AddBook(Book book)
        {
            Books.Add(book);
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
