/**** CHAPTER 4 EXAMPLES ****/

using Chapter04;

// Create an object of the Library class
Library library = new Library();

// Create three objects of the Book class
Book book1 = new Book("Contact", "Carl Sagan", 430);
Book book2 = new Book("Nemesis", "Isaac Asimov", 364);
Book book3 = new Book("1984", "George Orwell");

// Add books to library
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

// Print available books
library.PrintAvailableBooks();

// Check out book 1 and print available books again
book1.CheckOut();
library.PrintAvailableBooks();

// Check out book 2, check in book 1, and print available books again
book2.CheckOut();
book1.CheckIn();
library.PrintAvailableBooks();
