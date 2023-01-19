using System.Collections.Generic;

namespace RubyishCSharp.Library;

public static class Collections
{
    public static bool Empty<T>(this IEnumerable<T> collection)
    {
        return !collection.Any();
    }

    /// <summary>
    /// Returns a new collection from which items matching a given predicate
    /// have been removed.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <param name="predicate"></param>
    /// <returns>A new filtered collection.</returns>
    public static IEnumerable<T> Reject<T>(
        this IEnumerable<T> collection,
        Func<T, bool> predicate)
    {
        return collection.Where(x => !predicate(x));
    }

    /// <summary>
    /// Returns a new collection from which all null items have been removed.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <returns>A new filtered collection.</returns>
    public static IEnumerable<T> Compact<T>(this IEnumerable<T> collection)
    {
        return collection.Where(x => x != null);
    }
}
