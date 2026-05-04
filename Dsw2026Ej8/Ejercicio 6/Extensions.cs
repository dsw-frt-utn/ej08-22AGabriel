namespace Dsw2026Ej8;

public static class Extensions
{
    public static string ToProductCode(this string text)
    {
        if (text == null)
            return "SIN-COGIDO";

        return text.Trim().ToUpper().Replace(" ", "-");
    }
}