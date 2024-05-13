/**** CHAPTER 5 EXAMPLES ****/

using Chapter05;

// TODO: Print each book's id after its instantiation
Book book1 = new Book("Contact", "Carl Sagan", 430);
Book book2 = new Book("Nemesis", "Isaac Asimov", 364);
Book book3 = new Book("1984", "George Orwell");

// TODO: Test overridden ToString();

// Create a library
Library library = new Library();

// Add 3 books to library
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

// Print all available books
library.PrintAvailableBooks();

// TODO: Test overridden ToString() of library

// Three more books with identical contents of books above
Book book4 = new Book("Contact", "Carl Sagan", 430);
Book book5 = new Book("Nemesis", "Isaac Asimov", 364);
Book book6 = new Book("1984", "George Orwell");

// A second library
Library library2 = new Library();

// Add new books to new library
library2.AddBook(book4);
library2.AddBook(book5);
library2.AddBook(book6);

// TODO: Check equality of library with == operator
Console.WriteLine("\nAre the two libraries identical?");

// TODO: Check equality of library with overridden Equals() method
Console.WriteLine("\nAre the two libraries equal?");
