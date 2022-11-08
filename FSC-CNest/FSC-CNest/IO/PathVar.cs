using System.Reflection;

namespace FSC_CNest.IO
{
    public static class PathVar
    {
        public static string AppData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        
        public static string ExecutablePath { get; } = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location ?? string.Empty) ?? string.Empty;
        
        public static string ProgramData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        
        public static string Local { get; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        
        public static string Personal { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        
        public static string User { get; } = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        
        public static string Documents { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        public static string Music { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        
        public static string Pictures { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        
        public static string Videos { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        
        public static string ProgramFiles { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        
        public static string ProgramFilesX86 { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        
        public static string AdminTools { get; } = Environment.GetFolderPath(Environment.SpecialFolder.AdminTools);
        
        public static string CDBurn { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CDBurning);
        
        public static string DesktopDirectory { get; } = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        
        public static string Programs { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
        
        public static string StartMenu { get; } = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        
        public static string Startup { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        
        public static string SendTo { get; } = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
        
        public static string Templates { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
        
        public static string Cookies { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
        
        public static string Desktop { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        
        public static string Favorites { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
        
        public static string Fonts { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
        
        public static string History { get; } = Environment.GetFolderPath(Environment.SpecialFolder.History);
        
        public static string InternetCache { get; } = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
        
        public static string Computer { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        
        public static string NetworkShortcuts { get; } = Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts);
        
        public static string Recent { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
        
        public static string Resources { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Resources);
        
        public static string System { get; } = Environment.GetFolderPath(Environment.SpecialFolder.System);
        
        public static string System32 { get; } = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
        
        public static string Windows { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        
        public static string CurrentDrive { get; } = Path.GetPathRoot(Assembly.GetEntryAssembly()?.Location ?? string.Empty) ?? string.Empty;

        /// <summary>
        /// The same as: Environment.ExpandEnvironmentVariables(...)
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string EnvironmentVariablePath(string path)
        {
            return Environment.ExpandEnvironmentVariables(path);
        }

        /// <summary>
        /// The same as: Environment.GetEnvironmentVariable(...)
        /// </summary>
        /// <param name="variable"></param>
        /// <returns></returns>
        public static string? EnvironmentVariable(string variable)
        {
            return Environment.GetEnvironmentVariable(variable);
        }
    }
}
