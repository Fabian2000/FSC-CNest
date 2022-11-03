using FSC_CNest.WindowsNatives;

namespace FSC_CNest.IO
{
    public class LoggerOLD : IDisposable
    {
        private LoggingMethod loggingMethod;
        private string logName = "FSC-Logger.log";
        private string logTitle = "FSC-Logger";
        private StreamWriter? logFile = null;

        public LoggerOLD()
        {
            loggingMethod = LoggingMethod.File;
        }

        public LoggerOLD(LoggingMethod customLoggingMethod)
        {
            loggingMethod = customLoggingMethod;

            if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
            {
                if (OperatingSystem.IsWindows())
                {
                    Natives.AllocConsole();
                }
            }
        }

        public LoggerOLD(LoggingMethod customLoggingMethod, string customTitle)
        {
            loggingMethod = customLoggingMethod;

            if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
            {
                Console.Title = customTitle;
                
                if (OperatingSystem.IsWindows())
                {
                    Natives.AllocConsole();
                }
            }
        }

        /// <summary>
        /// This chooses a logging method for console, console and file or only file. If no console is available it will attach one
        /// </summary>
        public enum LoggingMethod
        {
            Console,
            File,
            ConsoleAndFile
        }

        /// <summary>
        /// Filename / Filepath for the log
        /// </summary>
        public string LogName
        {
            get
            {
                return logName;
            }
            set
            {
                logName = value;
            }
        }

        /// <summary>
        /// Log title for the console
        /// </summary>
        public string LogTitle
        {
            get
            {
                return logTitle;
            }
            set
            {
                logTitle = value;
                if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
                {
                    Console.Title = logTitle;
                }
            }
        }

        private string CreateLogMessage(string text, string logOperation)
        {
            string ret = String.Empty;
            ret += DateTime.Now.ToString("[dd-MM-yyyy HH:mm:ss]");
            ret += $" [{logOperation}] ";
            ret += text;
            return ret;
        }

        public void Info(string text)
        {
            text = CreateLogMessage(text, "INFO");

            if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
            {
                ConsoleColor cc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(text);

                Console.ForegroundColor = cc;
            }

            if (logFile == null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile = File.AppendText(logName);
            }

            if (logFile != null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile.WriteLine(text);
                logFile.Flush();
            }
        }

        public void Warning(string text)
        {
            text = CreateLogMessage(text, "WARNING");

            if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
            {
                ConsoleColor cc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(text);

                Console.ForegroundColor = cc;
            }

            if (logFile == null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile = File.AppendText(logName);
            }

            if (logFile != null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile.WriteLine(text);
                logFile.Flush();
            }
        }

        public void Error(string text)
        {
            text = CreateLogMessage(text, "ERROR");

            if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
            {
                ConsoleColor cc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(text);

                Console.ForegroundColor = cc;
            }

            if (logFile == null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile = File.AppendText(logName);
            }

            if (logFile != null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile.WriteLine(text);
                logFile.Flush();
            }
        }

        public void FatalError(string text)
        {
            text = CreateLogMessage(text, "FATAL");

            if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
            {
                ConsoleColor cc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine(text);

                Console.ForegroundColor = cc;
            }

            if (logFile == null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile = File.AppendText(logName);
            }

            if (logFile != null && (loggingMethod == LoggingMethod.ConsoleAndFile || loggingMethod == LoggingMethod.File))
            {
                logFile.WriteLine(text);
                logFile.Flush();
            }
        }

        ~LoggerOLD()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (loggingMethod == LoggingMethod.Console || loggingMethod == LoggingMethod.ConsoleAndFile)
            {
                if (OperatingSystem.IsWindows())
                {
                    Natives.FreeConsole();
                }
            }

            if (logFile != null)
            {
                logFile.Close();
            }

            GC.SuppressFinalize(this);
        }
    }
}
