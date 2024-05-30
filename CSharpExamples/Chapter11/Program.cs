using Chapter11;

/**** CHAPTER 11 EXAMPLES ****/

string[] numbersAsText = ["zero", "one", "two", "three", "four"];
PrintElementChars(numbersAsText, 7);

Console.WriteLine("The square root of 16 is " + GetSquareRoot(16));
Console.WriteLine("The square root of -5 is " + GetSquareRoot(-5));

String[] storyTypes = ["epic", "fable", "myth", "folktale"];

foreach (string type in storyTypes)
{
    try
    {
        if (!HasAVowel(type))
        {
            throw new NoVowelException(type);
        }
        else
        {
            Console.WriteLine(type);
        }
    }
    catch (NoVowelException e)
    {
        Console.WriteLine(e);
    }
}

static void PrintElementChars(string[] strArray, int idx)
{
    try
    {
        for (int i = 0; i < strArray[idx].Length; i++)
        {
            Console.WriteLine(strArray[idx][i]);
        }
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine(e.Message);
    }
}

static double GetSquareRoot(int n)
{
    try
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(
                "WARNING: Cannot take square root of negative number " + n
            );
        }
    }
    catch (ArgumentOutOfRangeException e)
    {
        Console.WriteLine(e);
    }
    return Math.Sqrt(Math.Abs(n));
}

static bool HasAVowel(string word)
{
    bool hasVowel = false;
    foreach (char letter in word.ToCharArray())
    {
        if ("aeiou".Contains(letter))
        {
            hasVowel = true;
            break;
        }
    }
    return hasVowel;
}
