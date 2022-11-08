namespace FSC_CNest.IO
{
    [Flags]
    public enum LogMethod
    {
        None = 0,
        /// <summary>
        /// Uses file logging
        /// </summary>
        File = 1,
        /// <summary>
        /// Adds a console to the program for logging
        /// </summary>
        Console = 2,
    }
}