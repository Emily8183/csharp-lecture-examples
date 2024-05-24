/**** Chapter 8 Examples ****/

using Chapter08;

// Several objects of various classes that inherit from Product
Book book = new("The Fellowship of the Ring", "The first book of the epic The Lord of the Rings trilogy", 18.99, 3, "JRR Tolkien", "Fantasy Fiction", "Hardcover");
UsedBook usedBook = new("Fahrenheit 451", "A masterpiece of dystopian storytelling", 6.50, 1, "Ray Bradbury", "Dystopian Fiction", "Hardcover", "Good");
Drinkware mug = new("Ahsoka Mug", "Have coffee with Ahsoka every day!", 13.99, 3, "Mugs", "Star Wars", "Ceramic", 15);
Apparel hat = new("Captain America Hat", "Feel like a supersoldier in this classic hat proudly displaying Captain America's vibranium shield", 19.99, 5, "Hats", "Marvel", ["OS"], ["navy", "gray"]);


/* POLYMORPHISM & CASTING WITH CLASS INHERITANCE */

// Book, UsedBook, Drinkware, Apparel — all Product objects
List<Product> items = [book, usedBook, mug, hat]; 

// TODO: Loop through the list and print the item and its condition if a UsedBook is found


/* WORKING WITH INTERFACES */

// TODO: Create a List to Test typing by interface instead of class

// TODO: Loop over list and test IDiscountable behaviors

    // Print IDiscountable item and see all properties

    // Apply flat discount of $2

    // Apply 50% discount

    // Cast to Product to access properties
    
    // Check current price as percentage of original price

    // Remove discount
