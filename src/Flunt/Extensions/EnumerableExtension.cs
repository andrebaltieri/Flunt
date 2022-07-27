namespace Flunt.Extensions;

public static class EnumerableExtension
{
    public static bool Contains(this IEnumerable<string> source, string value, StringComparison comparison) 
    {
        var contains = false;
        foreach (var item in source)
        {
            if (item.Equals(value, comparison))
                contains = true;
        }

        return contains;
    }
}