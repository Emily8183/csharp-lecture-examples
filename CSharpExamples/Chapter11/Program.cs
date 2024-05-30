using System.Text.RegularExpressions;
using Chapter11;

/**** CHAPTER 11 EXAMPLES ****/

string nl = Environment.NewLine;

// Argument Out of Range Exception
// Throw an existing exception on purpose
// Then handle it so the application doesn't crash

void PrintSquareRoot(int n)
{
    try
    {
        if (n < 0)
        {
            int neg = n;
            n = Math.Abs(n);
            throw new ArgumentOutOfRangeException(
                "WARNING: Cannot take square root of negative number " + neg
            );
        }
    }
    catch (ArgumentOutOfRangeException e)
    {
        Console.WriteLine(nl + e);
    }
    finally
    {
        Console.WriteLine(nl + "The square root of " 
            + n + " is " + Math.Sqrt(n));
    }
}

PrintSquareRoot(16);
PrintSquareRoot(-5);


// InvalidCastException
// Handle an exception that may or may not ever be an issue
// depending on whether someone uses the code correctly

Apparel hat = new("Hat", 24.99);
Book book = new("Book", 17.99);
UsedBook usedBook = new("Used Book", 6.49);

List<Product> products = [hat, book, usedBook];

foreach (Product product in products)
{
    try {
        ((IDiscountable)product).Discount(0.30);
    }
    catch (InvalidCastException e)
    {
        string stars = "*******************************************";
        Console.WriteLine(stars + nl 
            + e.Message + nl + stars);
    }
}

// Custom InvalidPatternException
// Provide internal quality control with data validation

bool HasInvalidFormat(string data, Regex pattern)
{
    bool isInvalid = !pattern.IsMatch(data);
    return isInvalid;
}

void CheckIdFormats(List<string> idList)
{
    int count = 0;
    foreach (string id in idList)
    {
        Regex validPattern = new(@"[A-Z][0-9]{3}-[A-Z][0-9]{2}-[A-Z]{2}");
        try
        {
            if (HasInvalidFormat(id, validPattern))
            {
                throw new InvalidPatternException(id, "A111-A11-AA");
            }
        }
        catch (InvalidPatternException e)
        {
            Console.WriteLine(e.Message);
            count++;
        }
    }
    Console.WriteLine("WARNING: " + count + " invalid pattern exceptions found.");
}

List<string> productIdList = ["A123-C45-YZ", "Q555-L66-AB", "ABCD-EFG-HI", "1234-567-89", "C56-N832-KG"];

CheckIdFormats(productIdList);
