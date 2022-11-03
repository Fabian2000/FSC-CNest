namespace FSC_CNest.Terminal
{
    public static class Terminal
    {
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

            // TODO: Password Code
            return null;
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

        public static uint ReadUint(string displayText)
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
            return GetCursorPosition();
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
    }
}
