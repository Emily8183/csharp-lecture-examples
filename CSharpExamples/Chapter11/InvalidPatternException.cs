namespace Chapter11;

public class InvalidPatternException : Exception
{
    public InvalidPatternException(string data, string example)
        : base(data + " is not formatted correctly. Example: " + example) { }
}
