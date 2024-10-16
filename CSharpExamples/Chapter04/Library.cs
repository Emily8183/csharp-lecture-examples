namespace Chapter04
{
    public class Library
    {
        private List<Book> books = []; //field. in this case, private is enough

        // Note: the default constructor is sufficient to instantiate a library object

        // INSTANCE METHODS

        public void AddBook(Book book)
        {
            books.Add(book);
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
