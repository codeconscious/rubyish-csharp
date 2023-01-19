using System.Collections.Generic;

namespace RubyishCSharp.Library;

public static class Collections
{
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
}
