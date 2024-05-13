/**** CHAPTER 5 EXAMPLES ****/

using Chapter05;

// Create 3 objects of the Book class and print their id after each
Book book1 = new Book("Contact", "Carl Sagan", 430);
Console.WriteLine("\nBook 1 has an ID of " + book1.BookId);

Book book2 = new Book("Nemesis", "Isaac Asimov", 364);
Console.WriteLine("Book 2 has an ID of " + book2.BookId);

Book book3 = new Book("1984", "George Orwell");
Console.WriteLine("Book 3 has an ID of " + book3.BookId);

// Test overridden ToString();
Console.WriteLine(book1);

// Create a library
Library library = new Library();

// Add 3 books to library
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

// Print all available books
library.PrintAvailableBooks();

// Test overridden ToString() of library
Console.WriteLine(library);

// Create three more books with identical contents of books above
Book book4 = new Book("Contact", "Carl Sagan", 430);
Book book5 = new Book("Nemesis", "Isaac Asimov", 364);
Book book6 = new Book("1984", "George Orwell");

// Create a new library
Library library2 = new Library();

// Add new books to new library
library2.AddBook(book4);
library2.AddBook(book5);
library2.AddBook(book6);

// Check equality of library with == operator
Console.WriteLine("\nAre the two libraries identical?");
Console.WriteLine(library == library2);

// Check equality of library with overridden Equals() method
Console.WriteLine("\nAre the two libraries equal?");
Console.WriteLine(Equals(library, library2));
