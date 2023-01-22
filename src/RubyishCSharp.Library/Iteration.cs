namespace RubyishCSharp.Library;

public static class Iterations
{
    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this nint count, Action action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (nint i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this nint count, Action<nint> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (int i = 0; i < count; i++)
        {
            action(i);
        }
    }

    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this nuint count, Action action)
    {
        if (count == 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (nuint i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this nuint count, Action<nuint> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (nuint i = 0; i < count; i++)
        {
            action(i);
        }
    }

    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this int count, Action action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (int i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this int count, Action<int> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (int i = 0; i < count; i++)
        {
            action(i);
        }
    }

    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    /// /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this uint count, Action action)
    {
        if (count == 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (int i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this uint count, Action<uint> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (uint i = 0; i < count; i++)
        {
            action(i);
        }
    }

    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this short count, Action action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (short i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this short count, Action<short> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (short i = 0; i < count; i++)
        {
            action(i);
        }
    }

    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this ushort count, Action action)
    {
        if (count == 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (ushort i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this ushort count, Action<int> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (ushort i = 0; i < count; i++)
        {
            action(i);
        }
    }

    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this byte count, Action action)
    {
        if (count == 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (byte i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this byte count, Action<int> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (byte i = 0; i < count; i++)
        {
            action(i);
        }
    }

    /// <summary>
    /// Run an action a specified number of times.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    /// <remarks>Example usage: 10.Times(() => Console.WriteLine())</remarks>
    public static void Times(this sbyte count, Action action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be greater than or equal to 1.");
        }

        for (sbyte i = 0; i < count; i++)
        {
            action();
        }
    }

    /// <summary>
    /// Run an action a specified number of times, passing the current iteration
    /// number to it each time.
    /// </summary>
    /// <param name="count">The number of times to run the action.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Times(this sbyte count, Action<int> action)
    {
        if (count < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(count), "The count must be positive.");
        }

        for (sbyte i = 0; i < count; i++)
        {
            action(i);
        }
    }
}
