using System.Text;

namespace FSC_CNest.Terminal
{
    public static class Terminal
    {
        #region Properties

        #region Color
        public static ConsoleColor BackgroundColor
        {
            get => Console.BackgroundColor;
            set => Console.BackgroundColor = value;
        }

        public static ConsoleColor ForegroundColor
        {
            get => Console.ForegroundColor;
            set => Console.ForegroundColor = value;
        }

        #endregion

        #region Buffer

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

        public static bool KeyAvailable
        {
            get => Console.KeyAvailable;
        }

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

        public static bool TreatControlCAsInput
        {
            get => Console.TreatControlCAsInput;
            set => Console.TreatControlCAsInput = value;
        }

        #endregion

        #region Cursor

        public static int CursorLeft
        {
            get => Console.CursorLeft;
            set => Console.CursorLeft = value;
        }

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

        public static int CursorTop
        {
            get => Console.CursorTop;
            set => Console.CursorTop = value;
        }

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

        public static TextWriter Error
        {
            get => Console.Error;
        }

        public static TextReader In
        {
            get => Console.In;
        }

        public static TextWriter Out
        {
            get => Console.Out;
        }

        #endregion

        #region Encoding

        public static Encoding InputEncoding
        {
            get => Console.InputEncoding;
            set => Console.InputEncoding = value;
        }

        public static Encoding OutputEncoding
        {
            get => Console.OutputEncoding;
            set => Console.OutputEncoding = value;
        }

        #endregion

        #region Redirected

        public static bool IsErrorRedirected
        {
            get => Console.IsErrorRedirected;
        }

        public static bool IsInputRedirected
        {
            get => Console.IsInputRedirected;
        }

        public static bool IsOutputRedirected
        {
            get => Console.IsOutputRedirected;
        }

        #endregion

        #region Window

        public static int LargestWindowHeight
        {
            get => Console.LargestWindowHeight;
        }

        public static int LargestWindowWidth
        {
            get => Console.LargestWindowWidth;
        }

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

        public static char PasswordChar { get; set; } = '*';

        #endregion

        #endregion

        #region Event

        public static event ConsoleCancelEventHandler? CancelKeyPress
        {
            add => Console.CancelKeyPress += value;
            remove => Console.CancelKeyPress -= value;
        }

        #endregion

        #region Methods

        #region Beep

        public static void Beep()
        {
            Console.Beep();
        }

        public static void Beep(int frequency, int duration)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.Beep(frequency, duration);
            }
        }

        #endregion

        #region Clear

        public static void Clear()
        {
            Console.Clear();
        }

        public static void Back()
        {
            Console.WriteLine("\b \b");
        }

        #endregion

        #region Read

        public static int Read()
        {
            return Read(string.Empty);
        }

        public static int Read(string displayText)
        {
            Console.Write(displayText);
            return Console.Read();
        }

        public static ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public static ConsoleKeyInfo ReadKey(bool intercept)
        {
            return Console.ReadKey(intercept);
        }

        #endregion

        #region ReadLines

        public static string? ReadLine()
        {
            return ReadLine(string.Empty);
        }

        public static string? ReadLine(bool hidePassword)
        {
            return ReadLine(string.Empty, hidePassword);
        }

        public static string? ReadLine(string displayText)
        {
            return ReadLine(displayText, false);
        }

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

        public static byte ReadByte()
        {
            return ReadByte(string.Empty);
        }

        public static byte ReadByte(string displayText)
        {
            if (byte.TryParse(ReadLine(displayText), out byte value))
            {
                return value;
            }

            return 0;
        }

        public static int ReadInt()
        {
            return ReadInt(string.Empty);
        }

        public static int ReadInt(string displayText)
        {
            if (int.TryParse(ReadLine(displayText), out int value))
            {
                return value;
            }

            return 0;
        }

        public static long ReadLong()
        {
            return ReadLong(string.Empty);
        }

        public static long ReadLong(string displayText)
        {
            if (long.TryParse(ReadLine(displayText), out long value))
            {
                return value;
            }

            return 0;
        }

        public static float ReadFloat()
        {
            return ReadFloat(string.Empty);
        }

        public static float ReadFloat(string displayText)
        {
            if (float.TryParse(ReadLine(displayText), out float value))
            {
                return value;
            }

            return 0;
        }

        public static double ReadDouble()
        {
            return ReadDouble(string.Empty);
        }

        public static double ReadDouble(string displayText)
        {
            if (double.TryParse(ReadLine(displayText), out double value))
            {
                return value;
            }

            return 0;
        }

        public static char ReadChar()
        {
            return ReadChar(string.Empty);
        }

        public static char ReadChar(string displayText)
        {
            if (char.TryParse(ReadLine(displayText), out char value))
            {
                return value;
            }

            return '\n';
        }

        public static uint ReadUInt()
        {
            return ReadChar(string.Empty);
        }

        public static uint ReadUInt(string displayText)
        {
            if (uint.TryParse(ReadLine(displayText), out uint value))
            {
                return value;
            }

            return 0;
        }

        public static ulong ReadULong()
        {
            return ReadULong(string.Empty);
        }

        public static ulong ReadULong(string displayText)
        {
            if (ulong.TryParse(ReadLine(displayText), out ulong value))
            {
                return value;
            }

            return 0;
        }

        public static bool ReadBool()
        {
            return ReadBool(string.Empty);
        }

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
