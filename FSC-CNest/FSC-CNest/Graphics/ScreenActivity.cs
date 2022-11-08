using FSC_CNest.WindowsNatives;
using System.Drawing;

namespace FSC_CNest.Graphics
{
    public class ScreenActivity
    {
        /// <summary>
        /// Picks a color from the given screen coordinates
        /// </summary>
        /// <param name="point"></param>
        /// <returns>Returns the picked color</returns>
        public static Color PickColor(Point point)
        {
            return PickColor(point.X, point.Y);
        }

        /// <summary>
        /// Picks a color from the given screen coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns the picked color</returns>
        public static Color PickColor(int x, int y)
        {
            if (!OperatingSystem.IsWindows())
            {
                return Color.Black;
            }

            var hdc = Natives.GetDC(IntPtr.Zero);
            var pixel = Natives.GetPixel(hdc, x, y);

            Natives.ReleaseDC(IntPtr.Zero, hdc);

            return Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
        }
    }
}
