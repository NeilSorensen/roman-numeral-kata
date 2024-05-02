namespace roman_numeral_kata;

public class Roman
{
    public static string FromInt(int number)
    {
        if (number == 5)
        {
            return "V";
        }
        return "I";
    }
}
