using RubyishCSharp.Library;

namespace RubyishCSharp.Tests;

public class CollectionsTests
{
    [Fact]
    public void Reject_ShortCollection_ReturnsNonRejectedItems()
    {
        var input = Enumerable.Range(ushort.MinValue, ushort.MaxValue).Select(i => (ushort)i);
        var expected = Enumerable.Range(ushort.MinValue, Math.Abs(ushort.MinValue)) // Only negative
                                 .Select(i => (ushort)i);
        var actual = input.Reject(i => i >= 0);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Reject_UshortCollection_ReturnsNonRejectedItems()
    {
        var input = Enumerable.Range(0, ushort.MaxValue).Select(i => (ushort)i);
        var expected = Enumerable.Range(0, 25_000).Select(i => (ushort)i);
        var actual = input.Reject(i => i >= 25_000);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Reject_IntCollection_ReturnsNonRejectedItems()
    {
        var input = Enumerable.Range(0, 100_000);
        var expected = Enumerable.Range(75_000, 25_000);
        var actual = input.Reject(i => i < 75_000);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Reject_UintCollection_ReturnsNonRejectedItems()
    {
        var input = Enumerable.Range(0, 100_000).Select(i => (uint)i);
        var expected = Enumerable.Range(75_000, 25_000).Select(i => (uint)i);
        var actual = input.Reject(i => i < 75_000);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Reject_NuintCollection_ReturnsNonRejectedItems()
    {
        var input = Enumerable.Range(0, 100_000).Select(i => (nuint)i);
        var expected = Enumerable.Range(75_000, 25_000).Select(i => (nuint)i);
        var actual = input.Reject(i => i < 75_000);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Reject_CharCollection_ReturnsNonRejectedItems()
    {
        var input = Enumerable.Range('A', 26).Select(i => (char)i); // A–Z
        var expected = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F' };
        var actual = input.Reject(ch => ch > 'F');
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Reject_StringCollection_ReturnsNonRejectedItems()
    {
        var input = Enumerable.Range('a', 26)
                              .Select(i => (char)i)
                              .Select(ch => new string(ch, 3)); // aaa–zzz
        var expected = new List<string> { "bbb", "ccc" };
        var actual = input.Reject(str => str != "bbb" && str != "ccc");
        Assert.Equal(expected, actual);
    }
}
