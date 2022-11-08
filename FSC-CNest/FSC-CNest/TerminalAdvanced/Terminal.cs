using System.Text;

namespace FSC_CNest.TerminalAdvanced
{
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
                {
                    return Console.CursorVisible;
                }

                return false;
            }
            set
            {
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
                if (OperatingSystem.IsWindows())
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
            if (OperatingSystem.IsWindows())
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
        /// 
        /// </summary>
        /// <returns></returns>
        public static byte ReadByte()
        {
            return ReadByte(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static byte ReadByte(string displayText)
        {
            if (byte.TryParse(ReadLine(displayText), out byte value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            return ReadInt(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static int ReadInt(string displayText)
        {
            if (int.TryParse(ReadLine(displayText), out int value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static long ReadLong()
        {
            return ReadLong(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static long ReadLong(string displayText)
        {
            if (long.TryParse(ReadLine(displayText), out long value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static float ReadFloat()
        {
            return ReadFloat(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static float ReadFloat(string displayText)
        {
            if (float.TryParse(ReadLine(displayText), out float value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static double ReadDouble()
        {
            return ReadDouble(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static double ReadDouble(string displayText)
        {
            if (double.TryParse(ReadLine(displayText), out double value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static char ReadChar()
        {
            return ReadChar(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static char ReadChar(string displayText)
        {
            if (char.TryParse(ReadLine(displayText), out char value))
            {
                return value;
            }

            return '\n';
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static uint ReadUInt()
        {
            return ReadChar(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static uint ReadUInt(string displayText)
        {
            if (uint.TryParse(ReadLine(displayText), out uint value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ulong ReadULong()
        {
            return ReadULong(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static ulong ReadULong(string displayText)
        {
            if (ulong.TryParse(ReadLine(displayText), out ulong value))
            {
                return value;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool ReadBool()
        {
            return ReadBool(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText"></param>
        /// <returns></returns>
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

        public static (int Left, int Top) GetCursorPosition()
        {
            return Console.GetCursorPosition();
        }

        public static void SetCursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }

        #endregion

        #region Buffer

        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
            }
        }

        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
            }
        }

        public static void SetBufferSize(int width, int height)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.SetBufferSize(width, height);
            }
        }

        #endregion

        #region Standard

        public static Stream OpenStandardError()
        {
            return Console.OpenStandardError();
        }

        public static Stream OpenStandardError(int bufferSize)
        {
            return Console.OpenStandardError(bufferSize);
        }

        public static Stream OpenStandardInput()
        {
            return Console.OpenStandardInput();
        }

        public static Stream OpenStandardInput(int bufferSize)
        {
            return Console.OpenStandardInput(bufferSize);
        }

        public static Stream OpenStandardOutput()
        {
            return Console.OpenStandardOutput();
        }

        public static Stream OpenStandardOutput(int bufferSize)
        {
            return Console.OpenStandardOutput(bufferSize);
        }

        #endregion

        #region Color

        public static void ResetColor()
        {
            Console.ResetColor();
        }

        #endregion

        #region Text

        public static void SetError(TextWriter newError)
        {
            Console.SetError(newError);
        }

        public static void SetIn(TextReader newIn)
        {
            Console.SetIn(newIn);
        }

        public static void SetOut(TextWriter newOut)
        {
            Console.SetOut(newOut);
        }

        #endregion

        #region Window

        public static void SetWindowPosition(int left, int top)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowPosition(left, top);
            }
        }

        public static void SetWindowSize(int width, int height)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(width, height);
            }
        }

        #endregion

        #region Write

        public static void Write(bool value)
        {
            Console.Write(value);
        }

        public static void Write(char value)
        {
            Console.Write(value);
        }

        public static void Write(char[]? buffer)
        {
            Console.Write(buffer);
        }

        public static void Write(char[] buffer, int index, int count)
        {
            Console.Write(buffer, index, count);
        }
        
        public static void Write(decimal value)
        {
            Console.Write(value);
        }
        
        public static void Write(double value)
        {
            Console.Write(value);
        }
        
        public static void Write(int value)
        {
            Console.Write(value);
        }

        public static void Write(long value)
        {
            Console.Write(value);
        }

        public static void Write(object? value)
        {
            Console.Write(value);
        }

        public static void Write(float value)
        {
            Console.Write(value);
        }

        public static void Write(string? value)
        {
            Console.Write(value);
        }

        public static void Write(string format, object? arg0)
        {
            Console.Write(format, arg0);
        }

        public static void Write(string format, object? arg0, object? arg1)
        {
            Console.Write(format, arg0, arg1);
        }

        public static void Write(string format, object? arg0, object? arg1, object? arg2)
        {
            Console.Write(format, arg0, arg1, arg2);
        }
        
        public static void Write(string format, params object?[]? arg)
        {
            Console.Write(format, arg);
        }

        public static void Write(uint value)
        {
            Console.Write(value);
        }
        
        public static void Write(ulong value)
        {
            Console.Write(value);
        }

        public static void WriteLine()
        {
            Console.WriteLine();
        }

        public static void WriteLine(bool value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(char value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(char[]? buffer)
        {
            Console.WriteLine(buffer);
        }

        public static void WriteLine(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }
        
        public static void WriteLine(decimal value)
        {
            Console.WriteLine(value);
        }
        
        public static void WriteLine(double value)
        {
            Console.WriteLine(value);
        }
        
        public static void WriteLine(int value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(long value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(object? value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(float value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(string? value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(string format, object? arg0)
        {
            Console.WriteLine(format, arg0);
        }

        public static void WriteLine(string format, object? arg0, object? arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }

        public static void WriteLine(string format, object? arg0, object? arg1, object? arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }
        
        public static void WriteLine(string format, params object?[]? arg)
        {
            Console.WriteLine(format, arg);
        }

        public static void WriteLine(uint value)
        {
            Console.WriteLine(value);
        }
        
        public static void WriteLine(ulong value)
        {
            Console.WriteLine(value);
        }

        #endregion

        #endregion
    }
}
