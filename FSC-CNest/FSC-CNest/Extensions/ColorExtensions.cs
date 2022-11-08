using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSC_CNest.Extensions
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Inverts a color
        /// </summary>
        /// <param name="color">The color to invert</param>
        /// <returns>Returns the inverted color</returns>
        public static Color Invert(this Color color)
        {
            return Color.FromArgb(color.ToArgb() ^ 0xffffff);
        }

        /// <summary>
        /// Makes a color gray.
        /// </summary>
        /// <param name="color">The color to change</param>
        /// <returns>Returns the new gray color</returns>
        public static Color GrayScale(this Color color)
        {
            var colorValue = (color.R + color.G + color.B) / 3;
            return Color.FromArgb(colorValue, colorValue, colorValue);
        }
    }
}
