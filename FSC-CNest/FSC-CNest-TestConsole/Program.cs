using FSC_CNest.Crypt;
using FSC_CNest.Extensions;
using FSC_CNest.Graphics;
using FSC_CNest.Hardware;
using FSC_CNest.IO;
using FSC_CNest.TerminalAdvanced;

namespace FSC_CNest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var u = Terminal.ReadLine("Username: ");
            var p = Terminal.ReadLine("Password: ", true);
            Terminal.WriteLine("{0}:{1}", u, p);
            Terminal.ReadKey();
        }
    }
}