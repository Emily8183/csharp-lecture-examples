namespace Chapter07;

public class Common
{
    public const string PIPE = " | ";
    
    public static string JoinList(List<string> list)
    {
        return string.Join(", ", list);
    }
}
