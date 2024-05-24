/**** Chapter 8 Examples ****/

using Chapter08;

// Several objects of various classes that inherit from Product
Book book =
    new(
        "The Fellowship of the Ring",
        "The first book of the epic The Lord of the Rings trilogy",
        18.99,
        3,
        "JRR Tolkien",
        "Fantasy Fiction",
        "Hardcover"
    );
UsedBook usedBook =
    new(
        "Fahrenheit 451",
        "A masterpiece of dystopian storytelling",
        6.50,
        1,
        "Ray Bradbury",
        "Dystopian Fiction",
        "Hardcover",
        "Good"
    );
Drinkware mug =
    new(
        "Ahsoka Mug",
        "Have coffee with Ahsoka every day!",
        13.99,
        3,
        "Mugs",
        "Star Wars",
        "Ceramic",
        15
    );
Apparel hat =
    new(
        "Captain America Hat",
        "Feel like a supersoldier in this classic hat proudly displaying Captain America's vibranium shield",
        19.99,
        5,
        "Hats",
        "Marvel",
        ["OS"],
        ["navy", "gray"]
    );

// Note: Collection expressions are new in C# v12 - [1, 2, 3] is short for new int[]{ 1, 2, 3 }

/* POLYMORPHISM & CASTING WITH CLASS INHERITANCE */

List<Product> items = [book, usedBook, mug, hat]; // Book, UsedBook, Drinkware, Apparel — all Product

// Loop through the list and print the condition if a UsedBook is found
foreach (Product item in items)
{
    if (item.GetType() == typeof(UsedBook))
    {
        // It will display the condition
        // because it is using the UsedBook implementation of ToString()
        Console.WriteLine(item);
        // Must cast the Product item to UsedBook to access Condition property
        Console.WriteLine("Condition: " + ((UsedBook)item).Condition);
    }
}

/* WORKING WITH INTERFACES */

// Print current state of hat
Console.WriteLine(hat);

// Apply flat discount of $3 to hat and reprint to show change
hat.ApplyFlatDiscount(3);
Console.WriteLine(hat);

// Apply 50% discount to hat and reprint
hat.ApplyPercentDiscount(50); // or 0.5
Console.WriteLine(hat); // 50% of original price, not already discounted

// Remove discount from hat and reprint
hat.RemoveDiscount();
Console.WriteLine(hat);

// Print current state of usedBook
Console.WriteLine(usedBook);

// Apply flat discount of $2 to usedBook
usedBook.ApplyFlatDiscount(2);
Console.WriteLine(usedBook);

// Apply 50% discount to usedBook
usedBook.ApplyPercentDiscount(0.50); // or 50
Console.WriteLine(usedBook); // 50% of already discounted price

// Remove discount from usedBook and reprint
usedBook.RemoveDiscount();
Console.WriteLine(usedBook);
