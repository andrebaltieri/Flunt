namespace Flunt.Extensions;

internal static class EnumerableExtension
{
    internal static bool Contains(this IEnumerable<string> source, string value, StringComparison comparison)
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