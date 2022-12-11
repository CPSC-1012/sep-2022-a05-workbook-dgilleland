public static class StringExtensions
{
    public static string Quack(this string self)
    {
        return $"{self} (quack)";
    }

    public static string Quack(this string self, int count)
    {
        string[] quacks = new string[count];
        for(int index = 0; index < count; index ++)
            quacks[index] = "quack";

        return $"{self} ({string.Join(',', quacks)})";
    }

    public static string AsQuotedString(this string self)
    {
        return $"\"{self}\"";
    }
}