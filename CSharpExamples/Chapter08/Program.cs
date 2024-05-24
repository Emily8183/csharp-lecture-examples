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

// Book, UsedBook, Drinkware, Apparel — all Product objects
List<Product> items = [book, usedBook, mug, hat]; 

// Loop through the list and print the condition if a UsedBook is found
foreach (Product item in items)
{
    if (item.GetType() == typeof(UsedBook))
    {
        // If we print the entire item it will display the condition
        // because it is using the UsedBook implementation of ToString()
        Console.WriteLine(item);

        // Must cast the Product item to UsedBook to access Condition property
        Console.WriteLine("Condition: " + ((UsedBook)item).Condition);
    }
}

/* WORKING WITH INTERFACES */

// Test typing by interface instead of class
List<IDiscountable> discountables = [hat, usedBook];

foreach (IDiscountable item in discountables)
{
    // Print IDiscountable item and see all properties
    Console.WriteLine(item);

    // Apply flat discount of $2
    item.ApplyFlatDiscount(2);

    // Apply 50% discount
    item.ApplyPercentDiscount(0.5); // or 50

    // Cast to Product to access properties
    Product product = (Product)item;
    
    // Check current price as percentage of original price
    double percentOfOriginal = Math.Round(100 * product.CurrentPrice / product.OriginalPrice);
    Console.WriteLine("The current price of the " + product.Name + " is " + percentOfOriginal + "% of the original price.");

    // Remove discount
    item.RemoveDiscount();
}
