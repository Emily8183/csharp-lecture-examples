/**** CHAPTER 6 EXAMPLES ****/

using Chapter06;

Book book1 = new Book("Contact", "Carl Sagan", 430);
Book book2 = new Book("Nemesis", "Isaac Asimov", 364);
Book book3 = new Book("1984", "George Orwell");

Library library = new Library();
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

Console.WriteLine(library);
