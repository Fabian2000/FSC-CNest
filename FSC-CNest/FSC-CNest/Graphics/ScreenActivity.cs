using FSC_CNest.WindowsNatives;
using System.Drawing;

namespace FSC_CNest.Graphics
{
    public class ScreenActivity
    {
        public static Bitmap? DoScreenshot(int x, int y, int width, int height)
        {
            if (!OperatingSystem.IsWindows())
            {
                return null;
            }

            var screen = new Bitmap(width - x, height - y);
            for (var i = x; i < width; i++)
            { 
                for (var j = y; j < height; j++)
                {
                    screen.SetPixel(i, j, PickColor(i, j));
                }
            }

            return screen;
        }

        public static Color PickColor(Point point)
        {
            return PickColor(point.X, point.Y);
        }

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
