using Chapter07;

// Instantiate several objects of various classes that inherit from Product
Book book1 = new("Pride and Prejudice", "This timeless classic showcases Austen's wit and winsome characters", 12.49, 6, "Jane Austen", "Romantic Fiction", "Paperback");
Book book2 = new("The Fellowship of the Ring", "The first book of the epic The Lord of the Rings trilogy", 18.99, 3, "JRR Tolkien", "Fantasy Fiction", "Hardcover");
UsedBook usedBook1 = new("Fahrenheit 451", "A masterpiece of dystopian storytelling", 6.50, 1, "Ray Bradbury", "Dystopian Fiction", "Hardcover", "Good");
UsedBook usedBook2 = new("A Pocket Full of Rye", "Miss Marple does it again in this twisty murder mystery", 4.75, 1, "Agatha Christie", "Mystery Fiction", "Paperback", "Fair");

// Print each item
Console.WriteLine(book1);
Console.WriteLine(book2);
Console.WriteLine(usedBook1);
Console.WriteLine(usedBook2);

// Describe each item
Console.WriteLine(book1.Describe());
Console.WriteLine(book2.Describe());
Console.WriteLine(usedBook1.Describe());
Console.WriteLine(usedBook2.Describe());
