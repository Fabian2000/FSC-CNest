namespace FSC_CNest.IO
{
    internal class Logger : IDisposable
    {
        private static readonly Logger _instance = new Logger();

        public Logger()
        {

        }

        public Logger(string filename, string title)
        {

        }

        public static Logger Instance { get => _instance; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
