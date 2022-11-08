using FSC_CNest.IO;
using FSC_CNest.WindowsNatives;
using System.Text;

namespace FSC_CNest.Hardware
{
    public static class Computer
    {
        /// <summary>
        /// Returns the hardware informations of the computer
        /// </summary>
        /// <param name="volumeSerialNumber"></param>
        /// <param name="volumeMaxComponentLength"></param>
        /// <param name="volumeFileSystemName"></param>
        /// <param name="computerName"></param>
        public static void GetHardwareInfo(out string? volumeSerialNumber, out string? volumeMaxComponentLength, out string? volumeFileSystemName, out string computerName)
        {
            GetHardwareInfo(PathVar.CurrentDrive, out volumeSerialNumber, out volumeMaxComponentLength, out volumeFileSystemName, out computerName);
        }

        /// <summary>
        /// Returns the hardware informations of the computer
        /// </summary>
        /// <param name="path"></param>
        /// <param name="volumeSerialNumber"></param>
        /// <param name="volumeMaxComponentLength"></param>
        /// <param name="volumeFileSystemName"></param>
        /// <param name="computerName"></param>
        /// <exception cref="PlatformNotSupportedException"></exception>
        public static void GetHardwareInfo(string path, out string? volumeSerialNumber, out string? volumeMaxComponentLength, out string? volumeFileSystemName, out string computerName)
        {
            if (!OperatingSystem.IsWindows())
            {
                throw new PlatformNotSupportedException();
            }

            uint serialNumber = 0;
            uint maxComponentLength = 0;
            var sbVolumeName = new StringBuilder(256);
            var fileSystemFlags = new UInt32();
            var sbFileSystemName = new StringBuilder(256);

            if (Natives.GetVolumeInformation(path, sbVolumeName, (uint)sbVolumeName.Capacity, ref serialNumber, ref maxComponentLength, ref fileSystemFlags, sbFileSystemName, (uint)sbFileSystemName.Capacity) != 0)
            {
                volumeSerialNumber = serialNumber.ToString();
                volumeMaxComponentLength = maxComponentLength.ToString();
                volumeFileSystemName = sbFileSystemName.ToString();
            }
            else
            {
                volumeSerialNumber = null;
                volumeMaxComponentLength = null;
                volumeFileSystemName = null;
            }

            computerName = Environment.MachineName;
        }
    }
}
