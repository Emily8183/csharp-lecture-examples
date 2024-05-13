/* CHAPTER 4 EXAMPLES */
using Chapter04;

Library library = new Library();

Book book1 = new Book("Contact", "Carl Sagan", 430);
Book book2 = new Book("Nemesis", "Isaac Asimov", 364);
Book book3 = new Book("1984", "George Orwell");

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

library.PrintAvailableBooks();

book1.CheckOut();

library.PrintAvailableBooks();

book2.CheckOut();
book1.CheckIn();

library.PrintAvailableBooks();
