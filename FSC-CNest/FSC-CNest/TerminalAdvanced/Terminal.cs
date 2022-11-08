using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace FSC_CNest.TerminalAdvanced
{
    /// <summary>
    /// Terminal is a 100% one to one copy from the console class with the same + advanced features. Don't use Console, use Terminal
    /// </summary>
    public static class Terminal
    {
        #region Properties

        #region Color
        /// <summary>
        /// Gets or sets the background color of the console
        /// </summary>
        public static ConsoleColor BackgroundColor
        {
            get => Console.BackgroundColor;
            set => Console.BackgroundColor = value;
        }

        /// <summary>
        /// Gets or sets the foreground color of the console.
        /// </summary>
        public static ConsoleColor ForegroundColor
        {
            get => Console.ForegroundColor;
            set => Console.ForegroundColor = value;
        }

        #endregion

        #region Buffer

        /// <summary>
        /// Gets or sets the height of the buffer area
        /// </summary>
        public static int BufferHeight
        {
            get => Console.BufferHeight;
            set 
            { 
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.BufferHeight = value; 
                }
            }
        }

        /// <summary>
        /// Gets or sets the width of the buffer area
        /// </summary>
        public static int BufferWidth
        {
            get => Console.BufferWidth;
            set 
            { 
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.BufferWidth = value; 
                }
            }
        }

        #endregion

        #region Key/s

        /// <summary>
        /// Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off
        /// </summary>
        public static bool CapsLock
        {
            get 
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return Console.CapsLock;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether a key press is available in the input stream
        /// </summary>
        public static bool KeyAvailable
        {
            get => Console.KeyAvailable;
        }

        /// <summary>
        /// Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off
        /// </summary>
        public static bool NumberLock
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return Console.NumberLock;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the combination of the System.ConsoleModifiers.Control modifier key and System.ConsoleKey.C console key (Ctrl+C) is treated as ordinary input or as an interruption that is handled by the operating system
        /// </summary>
        public static bool TreatControlCAsInput
        {
            get => Console.TreatControlCAsInput;
            set => Console.TreatControlCAsInput = value;
        }

        #endregion

        #region Cursor

        /// <summary>
        /// Gets or sets the column position of the cursor within the buffer area
        /// </summary>
        public static int CursorLeft
        {
            get => Console.CursorLeft;
            set => Console.CursorLeft = value;
        }

        /// <summary>
        /// Gets or sets the height of the cursor within a character cell
        /// </summary>
        public static int CursorSize
        {
            get => Console.CursorSize;
            set
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.CursorSize = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the row position of the cursor within the buffer area
        /// </summary>
        public static int CursorTop
        {
            get => Console.CursorTop;
            set => Console.CursorTop = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the cursor is visible
        /// </summary>
        public static bool CursorVisible
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return Console.CursorVisible;
                }

                return false;
            }
            set
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.CursorVisible = value;
                }
            }
        }

        #endregion

        #region Text

        /// <summary>
        /// Gets the standard error output stream
        /// </summary>
        public static TextWriter Error
        {
            get => Console.Error;
        }

        /// <summary>
        /// Gets the standard input stream
        /// </summary>
        public static TextReader In
        {
            get => Console.In;
        }

        /// <summary>
        /// Gets the standard output stream
        /// </summary>
        public static TextWriter Out
        {
            get => Console.Out;
        }

        #endregion

        #region Encoding

        /// <summary>
        /// Gets or sets the encoding the console uses to read input
        /// </summary>
        public static Encoding InputEncoding
        {
            get => Console.InputEncoding;
            set => Console.InputEncoding = value;
        }

        /// <summary>
        /// Gets or sets the encoding the console uses to write output
        /// </summary>
        public static Encoding OutputEncoding
        {
            get => Console.OutputEncoding;
            set => Console.OutputEncoding = value;
        }

        #endregion

        #region Redirected

        /// <summary>
        /// Gets a value that indicates whether the error output stream has been redirected from the standard error stream
        /// </summary>
        public static bool IsErrorRedirected
        {
            get => Console.IsErrorRedirected;
        }

        /// <summary>
        /// Gets a value that indicates whether input has been redirected from the standard input stream
        /// </summary>
        public static bool IsInputRedirected
        {
            get => Console.IsInputRedirected;
        }

        /// <summary>
        /// Gets a value that indicates whether output has been redirected from the standard output stream
        /// </summary>
        public static bool IsOutputRedirected
        {
            get => Console.IsOutputRedirected;
        }

        #endregion

        #region Window

        /// <summary>
        /// Gets the largest possible number of console window rows, based on the current font and screen resolution
        /// </summary>
        public static int LargestWindowHeight
        {
            get => Console.LargestWindowHeight;
        }

        /// <summary>
        /// Gets the largest possible number of console window columns, based on the current font and screen resolution
        /// </summary>
        public static int LargestWindowWidth
        {
            get => Console.LargestWindowWidth;
        }

        /// <summary>
        /// Gets or sets the title to display in the console title bar
        /// </summary>
        public static string Title
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return Console.Title;
                }

                return string.Empty;
            }
            set => Console.Title = value;
        }

        /// <summary>
        /// Gets or sets the height of the console window area
        /// </summary>
        public static int WindowHeight
        {
            get => Console.WindowHeight;
            set
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WindowHeight = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the width of the console window area
        /// </summary>
        public static int WindowWidth
        {
            get => Console.WindowWidth;
            set
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WindowWidth = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the leftmost position of the console window area relative to the screen buffer
        /// </summary>
        public static int WindowLeft
        {
            get => Console.WindowLeft;
            set
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WindowLeft = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the top position of the console window area relative to the screen buffer
        /// </summary>
        public static int WindowTop
        {
            get => Console.WindowTop;
            set
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WindowTop = value;
                }
            }
        }

        /// <summary>
        /// Sets the password char for readline methods with password enabled
        /// </summary>
        public static char PasswordChar { get; set; } = '*';

        #endregion

        #endregion

        #region Event

        /// <summary>
        /// Occurs when the System.ConsoleModifiers.Control modifier key (Ctrl) and either the System.ConsoleKey.C console key (C) or the Break key are pressed simultaneously (Ctrl+C or Ctrl+Break)
        /// </summary>
        public static event ConsoleCancelEventHandler? CancelKeyPress
        {
            add => Console.CancelKeyPress += value;
            remove => Console.CancelKeyPress -= value;
        }

        #endregion

        #region Methods

        #region Beep

        /// <summary>
        /// Plays the sound of a beep through the console speaker
        /// </summary>
        public static void Beep()
        {
            Console.Beep();
        }

        /// <summary>
        /// Plays the sound of a beep of a specified frequency and duration through the console speaker
        /// </summary>
        /// <param name="frequency">The frequency of the beep, ranging from 37 to 32767 hertz</param>
        /// <param name="duration">The duration of the beep measured in milliseconds</param>
        public static void Beep(int frequency, int duration)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.Beep(frequency, duration);
            }
        }

        #endregion

        #region Clear

        /// <summary>
        /// Clears the console buffer and corresponding console window of display information
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Works like pressing backspace and goes one char back in the console
        /// </summary>
        public static void Back()
        {
            Console.WriteLine("\b \b");
        }

        #endregion

        #region Read

        /// <summary>
        /// Reads the next character from the standard input stream
        /// </summary>
        /// <returns>The next character from the input stream, or negative one (-1) if there are currently no more characters to be read</returns>
        public static int Read()
        {
            return Read(string.Empty);
        }

        /// <summary>
        /// Reads the next character from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next character from the input stream, or negative one (-1) if there are currently no more characters to be read</returns>
        public static int Read(string displayText)
        {
            Console.Write(displayText);
            return Console.Read();
        }

        /// <summary>
        /// Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window
        /// </summary>
        /// <returns>An object that describes the System.ConsoleKey constant and Unicode character, if any, that correspond to the pressed console key. The System.ConsoleKeyInfo object also describes, in a bitwise combination of System.ConsoleModifiers values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key</returns>
        public static ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        /// <summary>
        /// Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window
        /// </summary>
        /// <param name="intercept">Determines whether to display the pressed key in the console window. true to not display the pressed key; otherwise, false</param>
        /// <returns>An object that describes the System.ConsoleKey constant and Unicode character, if any, that correspond to the pressed console key. The System.ConsoleKeyInfo object also describes, in a bitwise combination of System.ConsoleModifiers values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key</returns>
        public static ConsoleKeyInfo ReadKey(bool intercept)
        {
            return Console.ReadKey(intercept);
        }

        #endregion

        #region ReadLines

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream, or null if no more lines are available</returns>
        public static string? ReadLine()
        {
            return ReadLine(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="hidePassword">True: Hides the text with a password char</param>
        /// <returns>The next line of characters from the input stream, or null if no more lines are available</returns>
        public static string? ReadLine(bool hidePassword)
        {
            return ReadLine(string.Empty, hidePassword);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream, or null if no more lines are available</returns>
        public static string? ReadLine(string displayText)
        {
            return ReadLine(displayText, false);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <param name="hidePassword">True: Hides the text with a password char</param>
        /// <returns>The next line of characters from the input stream, or null if no more lines are available</returns>
        public static string? ReadLine(string displayText, bool hidePassword)
        {
            Console.Write(displayText);
            
            if (!hidePassword)
            {
                return Console.ReadLine();
            }

            var password = new StringBuilder();

            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    break;
                }
                else if (key.Key.Equals(ConsoleKey.Backspace))
                {
                    if (password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    password.Append(key.KeyChar.ToString());
                    Console.Write(PasswordChar);
                }
            }

            Console.WriteLine();
            return password.ToString();
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to byte, or 0 if no more lines are available</returns>
        public static byte ReadByte()
        {
            return ReadByte(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to byte, or 0 if no more lines are available</returns>
        public static byte ReadByte(string displayText)
        {
            if (byte.TryParse(ReadLine(displayText), out byte value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to int, or 0 if no more lines are available</returns>
        public static int ReadInt()
        {
            return ReadInt(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to int, or 0 if no more lines are available</returns>
        public static int ReadInt(string displayText)
        {
            if (int.TryParse(ReadLine(displayText), out int value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to long, or 0 if no more lines are available</returns>
        public static long ReadLong()
        {
            return ReadLong(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to long, or 0 if no more lines are available</returns>
        public static long ReadLong(string displayText)
        {
            if (long.TryParse(ReadLine(displayText), out long value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to float, or 0 if no more lines are available</returns>
        public static float ReadFloat()
        {
            return ReadFloat(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to float, or 0 if no more lines are available</returns>
        public static float ReadFloat(string displayText)
        {
            if (float.TryParse(ReadLine(displayText), out float value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to double, or 0 if no more lines are available</returns>
        public static double ReadDouble()
        {
            return ReadDouble(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to double, or 0 if no more lines are available</returns>
        public static double ReadDouble(string displayText)
        {
            if (double.TryParse(ReadLine(displayText), out double value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to char, or 0 if no more lines are available</returns>
        public static char ReadChar()
        {
            return ReadChar(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to char, or 0 if no more lines are available</returns>
        public static char ReadChar(string displayText)
        {
            if (char.TryParse(ReadLine(displayText), out char value))
            {
                return value;
            }

            return '\n';
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to uint, or 0 if no more lines are available</returns>
        public static uint ReadUInt()
        {
            return ReadChar(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to uint, or 0 if no more lines are available</returns>
        public static uint ReadUInt(string displayText)
        {
            if (uint.TryParse(ReadLine(displayText), out uint value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to ulong, or 0 if no more lines are available</returns>
        public static ulong ReadULong()
        {
            return ReadULong(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to ulong, or 0 if no more lines are available</returns>
        public static ulong ReadULong(string displayText)
        {
            if (ulong.TryParse(ReadLine(displayText), out ulong value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <returns>The next line of characters from the input stream converted to bool, or 0 if no more lines are available</returns>
        public static bool ReadBool()
        {
            return ReadBool(string.Empty);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream
        /// </summary>
        /// <param name="displayText">Adds a text before the user may input a text</param>
        /// <returns>The next line of characters from the input stream converted to bool, or 0 if no more lines are available</returns>
        public static bool ReadBool(string displayText)
        {
            switch (ReadLine(displayText)?.ToLower())
            {
                case "true":
                case "1":
                case "yes":
                case "y":
                case "agree":
                    return true;
            }

            return false;
        }

        #endregion

        #region Cursor

#if NET6_0_OR_GREATER
        /// <summary>
        /// Gets the position of the cursor
        /// </summary>
        /// <returns>The column and row position of the cursor</returns>
        public static (int Left, int Top) GetCursorPosition()
        {
            return Console.GetCursorPosition();
        }
#endif
        /// <summary>
        /// Sets the position of the cursor
        /// </summary>
        /// <param name="left">The column position of the cursor. Columns are numbered from left to right starting at 0</param>
        /// <param name="top">The row position of the cursor. Rows are numbered from top to bottom starting at 0</param>
        public static void SetCursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }

        #endregion

        #region Buffer

        /// <summary>
        /// Copies a specified source area of the screen buffer to a specified destination area
        /// </summary>
        /// <param name="sourceLeft">The leftmost column of the source area</param>
        /// <param name="sourceTop">The topmost row of the source area</param>
        /// <param name="sourceWidth">The number of columns in the source area</param>
        /// <param name="sourceHeight">The number of rows in the source area</param>
        /// <param name="targetLeft">The leftmost column of the destination area</param>
        /// <param name="targetTop">The topmost row of the destination area</param>
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
            }
        }

        /// <summary>
        /// Copies a specified source area of the screen buffer to a specified destination area
        /// </summary>
        /// <param name="sourceLeft">The leftmost column of the source area</param>
        /// <param name="sourceTop">The topmost row of the source area</param>
        /// <param name="sourceWidth">The number of columns in the source area</param>
        /// <param name="sourceHeight">The number of rows in the source area</param>
        /// <param name="targetLeft">The leftmost column of the destination area</param>
        /// <param name="targetTop">The topmost row of the destination area</param>
        /// <param name="sourceChar">The character used to fill the source area</param>
        /// <param name="sourceForeColor">The foreground color used to fill the source area</param>
        /// <param name="sourceBackColor">The background color used to fill the source area</param>
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
            }
        }

        /// <summary>
        /// Sets the height and width of the screen buffer area to the specified values
        /// </summary>
        /// <param name="width">The width of the buffer area measured in columns</param>
        /// <param name="height">The height of the buffer area measured in rows</param>
        public static void SetBufferSize(int width, int height)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetBufferSize(width, height);
            }
        }

        #endregion

        #region Standard

        /// <summary>
        /// Acquires the standard error stream
        /// </summary>
        /// <returns>The standard error stream</returns>
        public static Stream OpenStandardError()
        {
            return Console.OpenStandardError();
        }

        /// <summary>
        /// Acquires the standard error stream, which is set to a specified buffer size
        /// </summary>
        /// <param name="bufferSize">This parameter has no effect, but its value must be greater than or equal to zero</param>
        /// <returns>The standard error stream</returns>
        public static Stream OpenStandardError(int bufferSize)
        {
            return Console.OpenStandardError(bufferSize);
        }

        /// <summary>
        /// Acquires the standard input stream
        /// </summary>
        /// <returns>The standard input stream</returns>
        public static Stream OpenStandardInput()
        {
            return Console.OpenStandardInput();
        }

        /// <summary>
        /// Acquires the standard input stream, which is set to a specified buffer size
        /// </summary>
        /// <param name="bufferSize">This parameter has no effect, but its value must be greater than or equal to zero</param>
        /// <returns>The standard input stream</returns>
        public static Stream OpenStandardInput(int bufferSize)
        {
            return Console.OpenStandardInput(bufferSize);
        }

        /// <summary>
        /// Acquires the standard output stream
        /// </summary>
        /// <returns>The standard output stream</returns>
        public static Stream OpenStandardOutput()
        {
            return Console.OpenStandardOutput();
        }

        /// <summary>
        /// Acquires the standard output stream, which is set to a specified buffer size
        /// </summary>
        /// <param name="bufferSize">This parameter has no effect, but its value must be greater than or equal to zero</param>
        /// <returns>The standard output stream</returns>
        public static Stream OpenStandardOutput(int bufferSize)
        {
            return Console.OpenStandardOutput(bufferSize);
        }

        #endregion

        #region Color

        /// <summary>
        /// Sets the foreground and background console colors to their defaults
        /// </summary>
        public static void ResetColor()
        {
            Console.ResetColor();
        }

        #endregion

        #region Text

        /// <summary>
        /// Sets the System.Console.Error property to the specified System.IO.TextWriter object
        /// </summary>
        /// <param name="newError">A stream that is the new standard error output</param>
        public static void SetError(TextWriter newError)
        {
            Console.SetError(newError);
        }

        /// <summary>
        /// Sets the System.Console.In property to the specified System.IO.TextReader object
        /// </summary>
        /// <param name="newIn">A stream that is the new standard input</param>
        public static void SetIn(TextReader newIn)
        {
            Console.SetIn(newIn);
        }

        /// <summary>
        /// Sets the System.Console.Out property to target the System.IO.TextWriter object
        /// </summary>
        /// <param name="newOut">A text writer to be used as the new standard output</param>
        public static void SetOut(TextWriter newOut)
        {
            Console.SetOut(newOut);
        }

        #endregion

        #region Window

        /// <summary>
        /// Sets the position of the console window relative to the screen buffer
        /// </summary>
        /// <param name="left">The column position of the upper left corner of the console window</param>
        /// <param name="top">The row position of the upper left corner of the console window</param>
        public static void SetWindowPosition(int left, int top)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowPosition(left, top);
            }
        }

        /// <summary>
        /// Sets the height and width of the console window to the specified values
        /// </summary>
        /// <param name="width">The width of the console window measured in columns</param>
        /// <param name="height">The height of the console window measured in rows</param>
        public static void SetWindowSize(int width, int height)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(width, height);
            }
        }

        #endregion

        #region Write

        /// <summary>
        /// Writes the text representation of the specified Boolean value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(bool value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the specified Unicode character value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(char value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the specified array of Unicode characters to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(char[]? buffer)
        {
            Console.Write(buffer);
        }

        /// <summary>
        /// Writes the specified subarray of Unicode characters to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(char[] buffer, int index, int count)
        {
            Console.Write(buffer, index, count);
        }

        /// <summary>
        /// Writes the text representation of the specified System.Decimal value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(decimal value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified double-precision floating-point value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(double value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit signed integer value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(int value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit signed integer value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(long value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified object to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(object? value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified single-precision floating-point value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(float value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(string? value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified object to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg0">An object to write using format</param>
        public static void Write(string format, object? arg0)
        {
            Console.Write(format, arg0);
        }

        /// <summary>
        /// Writes the text representation of the specified objects to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg0">The first object to write using format</param>
        /// <param name="arg1">The second object to write using format</param>
        public static void Write(string format, object? arg0, object? arg1)
        {
            Console.Write(format, arg0, arg1);
        }

        /// <summary>
        /// Writes the text representation of the specified objects to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg0">The first object to write using format</param>
        /// <param name="arg1">The second object to write using format</param>
        /// <param name="arg2">The third object to write using format</param>
        public static void Write(string format, object? arg0, object? arg1, object? arg2)
        {
            Console.Write(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Writes the text representation of the specified array of objects to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg">An array of objects to write using format</param>
        public static void Write(string format, params object?[]? arg)
        {
            Console.Write(format, arg);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(uint value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void Write(ulong value)
        {
            Console.Write(value);
        }
        #endregion

        #region WriteLine

        /// <summary>
        /// Writes the current line terminator to the standard output stream
        /// </summary>
        public static void WriteLine()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(bool value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(char value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="buffer">A Unicode character array</param>
        public static void WriteLine(char[]? buffer)
        {
            Console.WriteLine(buffer);
        }

        /// <summary>
        /// Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="buffer">An array of Unicode characters</param>
        /// <param name="index">The starting position in buffer</param>
        /// <param name="count">The number of characters to write</param>
        public static void WriteLine(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }

        /// <summary>
        /// Writes the text representation of the specified System.Decimal value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(decimal value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(double value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(int value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(long value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(object? value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(float value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(string? value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg0">An object to write using format</param>
        public static void WriteLine(string format, object? arg0)
        {
            Console.WriteLine(format, arg0);
        }

        /// <summary>
        /// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg0">The first object to write using format</param>
        /// <param name="arg1">The second object to write using format</param>
        public static void WriteLine(string format, object? arg0, object? arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }

        /// <summary>
        /// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg0">The first object to write using format</param>
        /// <param name="arg1">The second object to write using format</param>
        /// <param name="arg2">The third object to write using format</param>
        public static void WriteLine(string format, object? arg0, object? arg1, object? arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="arg">An array of objects to write using format</param>
        public static void WriteLine(string format, params object?[]? arg)
        {
            Console.WriteLine(format, arg);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(uint value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the standard output stream
        /// </summary>
        /// <param name="value">The value to write</param>
        public static void WriteLine(ulong value)
        {
            Console.WriteLine(value);
        }

        #endregion

        #endregion
    }
}
