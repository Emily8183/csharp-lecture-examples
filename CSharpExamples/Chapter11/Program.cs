using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Chapter11;

/**** CHAPTER 11 EXAMPLES ****/

string nl = Environment.NewLine;

// Argument Out of Range Exception
// TODO: Throw an existing exception on purpose
// Then handle it so the application doesn't crash

void PrintSquareRoot(int n)
{
    Console.WriteLine(nl + "The square root of " + n + " is " + Math.Sqrt(n));
}

PrintSquareRoot(16);
PrintSquareRoot(-5);


// InvalidCastException
// TODO: Handle an exception that may or may not ever be an issue
// depending on whether someone uses the code correctly

Apparel hat = new("Hat", 24.99);
Book book = new("Book", 17.99);
UsedBook usedBook = new("Used Book", 6.49);

List<Product> products = [hat, book, usedBook];

foreach (Product product in products)
{
    // ((IDiscountable)product).Discount(0.30);
}

// Custom InvalidPatternException
// TODO: Write a custom exception
// Then do some internal quality control with data validation

bool HasInvalidFormat(string data, Regex pattern)
{
    bool isInvalid = !pattern.IsMatch(data);
    return isInvalid;
}

void CheckIdFormats(List<string> idList)
{
    foreach (string id in idList)
    {
        Regex validPattern = new(@"[A-Z][0-9]{3}-[A-Z][0-9]{2}-[A-Z]{2}");
        if (HasInvalidFormat(id, validPattern))
        {
            Console.WriteLine("Oh noes!");
        }
    }
}

List<string> productIdList = ["A123-C45-YZ", "Q555-L66-AB", "ABCD-EFG-HI", "1234-567-89", "C56-N832-KG"];

CheckIdFormats(productIdList);

// TODO: (Chapter 12) Introduce a logic error in HasInvalid Format
// Then put a breakpoint where it is called inside CheckIdFormats to debug
// Watch id and isInvalid to see where values change
