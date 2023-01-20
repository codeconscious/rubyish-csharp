using System;
using RubyishCSharp.Library;

namespace RubyishCSharp.Tests;

public static class CollectionsTests
{
    public class EmptyTests
    {
        [Fact]
        public void Empty_EmptyEnumerable_ReturnsTrue()
        {
            var input = Enumerable.Empty<int>();
            const bool expected = true;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_PopulatedEnumerable_ReturnsFalse()
        {
            var input = Enumerable.Range(0, 1);
            const bool expected = false;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_NullEnumerable_ThrowsError()
        {
            IEnumerable<int>? nullEnumerable = null;
            Assert.Throws<ArgumentNullException>(() => nullEnumerable!.Empty());
        }

        [Fact]
        public void Empty_EmptyList_ReturnsTrue()
        {
            var input = new List<uint>();
            const bool expected = true;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_PopulatedList_ReturnsFalse()
        {
            var input = new List<uint>() { uint.MinValue, uint.MaxValue};
            const bool expected = false;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_NullList_ThrowsError()
        {
            List<int>? nullList = null;
            Assert.Throws<NullReferenceException>(() => nullList!.Empty());
        }

        [Fact]
        public void Empty_EmptyArray_ReturnsTrue()
        {
            var input = Array.Empty<string>();
            const bool expected = true;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_PopulatedArray_ReturnsFalse()
        {
            var input = new string[] { "aa", "bb", "cc" };
            const bool expected = false;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_NullArray_ThrowsError()
        {
            int[]? nullArray = null;
            Assert.Throws<NullReferenceException>(() => nullArray!.Empty());
        }

        [Fact]
        public void Empty_EmptyStack_ReturnsTrue()
        {
            var input = new Stack<short>();
            const bool expected = true;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_PopulatedStack_ReturnsFalse()
        {
            var input = new Stack<short>(new[] { short.MinValue, short.MaxValue });
            const bool expected = false;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_NullStack_ThrowsError()
        {
            Stack<short>? nullStack = null;
            Assert.Throws<ArgumentNullException> (() => nullStack!.Empty());
        }

        [Fact]
        public void Empty_EmptyQueue_ReturnsTrue()
        {
            var input = new Queue<short>();
            const bool expected = true;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_PopulatedQueue_ReturnsFalse()
        {
            var input = new Queue<short>(new[] { short.MinValue, short.MaxValue });
            const bool expected = false;
            var actual = input.Empty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Empty_NullQueue_ThrowsError()
        {
            Queue<short>? nullQueue = null;
            Assert.Throws<ArgumentNullException>(() => nullQueue!.Empty());
        }
    }

    public class RejectTests
    {
        [Fact]
        public void Reject_ShortCollection_ReturnsNonRejectedItems()
        {
            var input = Enumerable.Range(short.MinValue, short.MaxValue * 2)
                                  .Select(i => (short)i);
            var expected = Enumerable.Range(short.MinValue, short.MaxValue + 1)
                                     .Select(i => (short)i); // Only negative numbers.
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
