namespace Chapter07;

public class Common
{
    public static string JoinWithComma(List<string> list)
    {
        return string.Join(", ", list);
    }

    public static string JoinWithPipe(string[] arr)
    {
        return string.Join(" | ", arr);
    }
}
