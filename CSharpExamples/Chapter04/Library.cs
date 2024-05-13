namespace Chapter04
{
    public class Library
    {
        private List<Book> books = [];

        // Note: the default constructor is sufficient to instantiate a library object
    

        public void AddBook(Book book)
        {
            books.Add(book);
        }

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
