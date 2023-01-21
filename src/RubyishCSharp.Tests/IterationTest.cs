using RubyishCSharp.Library;

namespace RubyishCSharp.Tests;

public static class IterationTest
{
    public static class TimesTests
    {
        public class Nint
        {
            [Fact]
            public void Times_NormalExecution_RunsExpectedNumberOfTimes()
            {
                const nint iterationCount = 5000;
                nint actualCount = 0;
                iterationCount.Times(() => actualCount++);
                Assert.Equal(iterationCount, actualCount);
            }

            [Fact]
            public void Times_PassingCurrentIteration_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 5000;
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(i => (nint) i);
                var actualItems = new List<nint>();
                iterationCount.Times(i => actualItems.Add(i));
                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_PassingCurrentIterationInString_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var stringGenerator = new Func<nint, string>(i => $"Iteration #{i}");
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(i => (nint) i)
                                              .Select(stringGenerator);

                var actualItems = new List<string>();
                iterationCount.Times(i => actualItems.Add(stringGenerator(i)));

                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_ZeroIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((nint) 0).Times(() => Console.WriteLine()));
            }

            [Fact]
            public void Times_NegativeIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((nint) (-1)).Times(() => Console.WriteLine()));
            }
        }

        public class Nuint
        {
            [Fact]
            public void Times_NormalExecution_RunsExpectedNumberOfTimes()
            {
                const nuint iterationCount = 5000;
                nuint actualCount = 0;
                iterationCount.Times(() => actualCount++);
                Assert.Equal(iterationCount, actualCount);
            }

            [Fact]
            public void Times_PassingCurrentIteration_RunsExpectedNumberOfTimes()
            {
                const nuint iterationCount = 5000;
                var expectedItems = Enumerable.Range(0, (int) iterationCount)
                                              .Select(i => (nuint) i);
                var actualItems = new List<nuint>();
                iterationCount.Times(actualItems.Add);
                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_PassingCurrentIterationInString_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var stringGenerator = new Func<nint, string>(i => $"Iteration #{i}");
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(i => (nint) i)
                                              .Select(stringGenerator);

                var actualItems = new List<string>();
                iterationCount.Times(i => actualItems.Add(stringGenerator(i)));

                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_ZeroIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((nuint) 0).Times(() => Console.WriteLine()));
            }
        }

        public class Int
        {
            [Fact]
            public void Times_NormalExecution_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var actualCount = 0;
                iterationCount.Times(() => actualCount++);
                Assert.Equal(iterationCount, actualCount);
            }

            [Fact]
            public void Times_PassingCurrentIteration_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var expectedItems = Enumerable.Range(0, iterationCount);
                var actualItems = new List<int>();
                iterationCount.Times(actualItems.Add);
                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_PassingCurrentIterationInString_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var stringGenerator = new Func<int, string>(i => $"Iteration #{i}");
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(stringGenerator);

                var actualItems = new List<string>();
                iterationCount.Times(i => actualItems.Add(stringGenerator(i)));

                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_ZeroIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => 0.Times(() => Console.WriteLine()));
            }

            [Fact]
            public void Times_NegativeIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => (-1).Times(() => Console.WriteLine()));
            }
        }

        public class Short
        {
            [Fact]
            public void Times_NormalExecution_RunsExpectedNumberOfTimes()
            {
                const short iterationCount = 500;
                var actualCount = 0;
                iterationCount.Times(() => actualCount++);
                Assert.Equal(iterationCount, actualCount);
            }

            [Fact]
            public void Times_PassingCurrentIteration_RunsExpectedNumberOfTimes()
            {
                const short iterationCount = 500;
                var expectedItems = Enumerable.Range(0, iterationCount).Select(i => (short) i);
                var actualItems = new List<short>();
                iterationCount.Times(actualItems.Add);
                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_PassingCurrentIterationInString_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var stringGenerator = new Func<int, string>(i => $"Iteration #{i}");
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(stringGenerator);

                var actualItems = new List<string>();
                iterationCount.Times(i => actualItems.Add(stringGenerator(i)));

                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_ZeroIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((short) 0).Times(() => Console.WriteLine()));
            }

            [Fact]
            public void Times_NegativeIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((short) -1).Times(() => Console.WriteLine()));
            }
        }

        public class Ushort
        {
            [Fact]
            public void Times_NormalExecution_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var actualCount = 0;
                iterationCount.Times(() => actualCount++);
                Assert.Equal(iterationCount, actualCount);
            }

            [Fact]
            public void Times_PassingCurrentIteration_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var expectedItems = Enumerable.Range(0, iterationCount);
                var actualItems = new List<int>();
                iterationCount.Times(actualItems.Add);
                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_PassingCurrentIterationInString_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var stringGenerator = new Func<int, string>(i => $"Iteration #{i}");
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(stringGenerator);

                var actualItems = new List<string>();
                iterationCount.Times(i => actualItems.Add(stringGenerator(i)));

                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_ZeroIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((ushort) 0).Times(() => Console.WriteLine()));
            }
        }

        public class Byte
        {
            [Fact]
            public void Times_NormalExecution_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var actualCount = 0;
                iterationCount.Times(() => actualCount++);
                Assert.Equal(iterationCount, actualCount);
            }

            [Fact]
            public void Times_PassingCurrentIteration_RunsExpectedNumberOfTimes()
            {
                const byte iterationCount = 50;
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(i => (byte) i);
                var actualItems = new List<byte>();
                iterationCount.Times(i => actualItems.Add((byte) i));
                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_PassingCurrentIterationInString_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var stringGenerator = new Func<int, string>(i => $"Iteration #{i}");
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(stringGenerator);

                var actualItems = new List<string>();
                iterationCount.Times(i => actualItems.Add(stringGenerator(i)));

                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_ZeroIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((byte) 0).Times(() => Console.WriteLine()));
            }
        }

        public class Sbyte
        {
            [Fact]
            public void Times_NormalExecution_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var actualCount = 0;
                iterationCount.Times(() => actualCount++);
                Assert.Equal(iterationCount, actualCount);
            }

            [Fact]
            public void Times_PassingCurrentIteration_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var expectedItems = Enumerable.Range(0, iterationCount);
                var actualItems = new List<int>();
                iterationCount.Times(actualItems.Add);
                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_PassingCurrentIterationInString_RunsExpectedNumberOfTimes()
            {
                const int iterationCount = 500;
                var stringGenerator = new Func<int, string>(i => $"Iteration #{i}");
                var expectedItems = Enumerable.Range(0, iterationCount)
                                              .Select(stringGenerator);

                var actualItems = new List<string>();
                iterationCount.Times(i => actualItems.Add(stringGenerator(i)));

                Assert.Equal(expectedItems, actualItems);
            }

            [Fact]
            public void Times_ZeroIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((sbyte) 0).Times(() => Console.WriteLine()));
            }

            [Fact]
            public void Times_NegativeIterationCount_ThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => ((sbyte) -1).Times(() => Console.WriteLine()));
            }
        }
    }
}
