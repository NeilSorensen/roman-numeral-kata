namespace roman_numeral_kata;

public class Roman
{
    private static Dictionary<int, string> numberMap = new Dictionary<int, string> {
        {1, "I"},
        {5, "V"}
    };
    public static string FromInt(int number)
    {
        return numberMap[number];
    }
}
