namespace Asterisk.MyTek.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> items) => items.Select((i, x) => (i, x));
}
