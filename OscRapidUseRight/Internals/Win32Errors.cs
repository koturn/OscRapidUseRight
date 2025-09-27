#if !NET7_0_OR_GREATER


namespace OscRapidUseRight.Internals
{
    /// <summary>
    /// Win32 error codes used in this library.
    /// </summary>
    /// <remarks>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/debug/system-error-codes"/>
    /// </remarks>
    internal enum Win32Errors
    {
        InsufficientBuffer = 122
    }
}


#endif  // !NET7_0_OR_GREATER
