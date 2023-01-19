using RubyishCSharp.Library;

namespace RubyishCSharp.Tests;

public static class CollectionsTests
{
    public class RejectTests
    {
        [Fact]
        public void Reject_ShortCollection_ReturnsNonRejectedItems()
        {
            var input = Enumerable.Range(short.MinValue, short.MaxValue * 2)
                                  .Select(i => (short)i);
            var expected = Enumerable.Range(short.MinValue, short.MaxValue + 1) // Only negative
                                     .Select(i => (short)i);
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

    public class CompactTests
    {
        [Fact]
        public void Compact_NullableShortCollectionWithNulls_ReturnsNonNullItems()
        {
            var input = new List<short?> { -3, null, -1, null, 1, null, 3 };
            var expected = new List<short?> { -3, -1, 1, 3 };
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_NullableShortCollectionWithoutNulls_ReturnsNonNullItems()
        {
            var input = new List<short?> { -3, -1, 1, 3 };
            var expected = input;
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_NullableShortCollectionOnlyNulls_ReturnsEmptyCollection()
        {
            var input = new List<short?> { null, null, null, null, null };
            var expected = Enumerable.Empty<short?>();
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_NonNullableShortCollection_ReturnsAllItems()
        {
            var input = new List<short> { -3, -1, 1, 3 };
            var expected = new List<short> { -3, -1, 1, 3 };
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_EmptyNullableShortCollection_ReturnsEmptyCollection()
        {
            var input = Enumerable.Empty<short?>();
            var expected = Enumerable.Empty<short?>();
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_EmptyNonNullableShortCollection_ReturnsEmptyCollection()
        {
            var input = Enumerable.Empty<short>();
            var expected = Enumerable.Empty<short>();
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_EmptyNonNullableStringCollection_ReturnsEmptyCollection()
        {
            var input = Enumerable.Empty<string>();
            var expected = Enumerable.Empty<string>();
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_EmptyNullableStringCollection_ReturnsEmptyCollection()
        {
            var input = Enumerable.Empty<string?>();
            var expected = Enumerable.Empty<string?>();
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_PopulatedNullableStringCollection_ReturnsEmptyCollection()
        {
            var input = Enumerable.Range('a', 26)
                                  .Select(i => (char)i)
                                  .Select(ch => (string?) new string(ch, 3)); // aaa–zzz
            var expected = input;
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_PopulatedNonNullableStringCollection_ReturnsEmptyCollection()
        {
            var input = Enumerable.Range('a', 26)
                                  .Select(i => (char)i)
                                  .Select(ch => new string(ch, 3)); // aaa–zzz
            var expected = input;
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Compact_AllNullCollection_ReturnsEmptyCollection()
        {
            var input = Enumerable.Repeat<string?>(null, 1000);
            var expected = Enumerable.Empty<string>();
            var actual = input.Compact();
            Assert.Equal(expected, actual);
        }
    }
}
