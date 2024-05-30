namespace Chapter11;

public class NoVowelException : Exception
{
    public NoVowelException(string word)
        : base("WARNING: The word '" + word + "' has no standard vowels.") { }
}
