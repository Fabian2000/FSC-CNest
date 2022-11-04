using FSC_CNest.TerminalAdvanced;
using FSC_CNest.WindowsNatives;
using System.Diagnostics;
using System.Text;

namespace FSC_CNest.IO
{
    public class Logger : IDisposable
    {
        private static readonly Logger _instance = new();
        private StreamWriter? _logWriter = null;
        private bool _terminalAttached = false;

        public Logger()
        {

        }

        public Logger(LogMethod flags)
        {
            Flags = flags;
        }

        public Logger(string filename, string title)
        {
            FileName = filename;
            Title = title;
        }

        public Logger(string filename, string title, LogMethod flags)
        {
            FileName = filename;
            Title= title;
            Flags = flags;
        }

        public static Logger Instance { get => _instance; }

        public LogMethod Flags { get; set; } = LogMethod.None;

        public string FileName { get; set; } = AppDomain.CurrentDomain.FriendlyName + ".log";

        public string Title { get; set; } = AppDomain.CurrentDomain.FriendlyName;

        private void Write(LogType logType, string text, out string message)
        {
            var messageBuilder = new StringBuilder();

            messageBuilder.Append(DateTime.Now.ToString("[dd-MM-yyyy HH:mm:ss]"));
            messageBuilder.Append("\t");
            messageBuilder.Append($"[{logType.ToString().ToUpper()}]");
            messageBuilder.Append("\t\t");
            messageBuilder.Append(text);

            message = messageBuilder.ToString();
        }

        private void OpenFile()
        {
            if (_logWriter == null && Flags.HasFlag(LogMethod.File))
            {
                _logWriter = File.AppendText(FileName);
            }
        }

        private void CommandLine(LogType logType, string message)
        {
            if (OperatingSystem.IsWindows() && Flags.HasFlag(LogMethod.Console))
            {
                if (!_terminalAttached)
                {
                    Natives.AllocConsole();
                    Terminal.Title = Title.Trim();
                }

                ConsoleColor backupColor = Terminal.ForegroundColor;
                
                switch (logType)
                {
                    case LogType.Info:
                        break;
                    case LogType.Note:
                        Terminal.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case LogType.Warning:
                        Terminal.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case LogType.Error:
                    case LogType.Fatal:
                        Terminal.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Terminal.WriteLine(message);
                Terminal.ForegroundColor = backupColor;
            }
        }

        public void Start()
        {
            OpenFile();
            _logWriter?.WriteLine($"[Start(Title:{Title}, Name:{Path.GetFileName(FileName)}, GUID:{Guid.NewGuid().ToString()})]");
            _logWriter?.Flush();
        }

        public void Info(string logMessage)
        {            
            Write(LogType.Info, logMessage, out string message);
            OpenFile();
            _logWriter?.WriteLine(message);
            _logWriter?.Flush();
            CommandLine(LogType.Info, message);
        }

        public void Note(string logMessage)
        {            
            Write(LogType.Note, logMessage, out string message);
            OpenFile();
            _logWriter?.WriteLine(message);
            _logWriter?.Flush();
            CommandLine(LogType.Note, message);
        }

        public void Warning(string logMessage)
        {            
            Write(LogType.Warning, logMessage, out string message);
            OpenFile();
            _logWriter?.WriteLine(message);
            _logWriter?.Flush();
            CommandLine(LogType.Warning, message);
        }

        public void Error(string logMessage)
        {            
            Write(LogType.Error, logMessage, out string message);
            OpenFile();
            _logWriter?.WriteLine(message);
            _logWriter?.Flush();
            CommandLine(LogType.Error, message);
        }

        public void FatalError(string logMessage)
        {            
            Write(LogType.Fatal, logMessage, out string message);
            OpenFile();
            _logWriter?.WriteLine(message);
            _logWriter?.Flush();
            CommandLine(LogType.Fatal, message);

            Process.GetCurrentProcess().Kill();
        }

        ~Logger()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (_terminalAttached)
            {
                Natives.FreeConsole();
            }

            _logWriter?.Close();
            _logWriter?.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
