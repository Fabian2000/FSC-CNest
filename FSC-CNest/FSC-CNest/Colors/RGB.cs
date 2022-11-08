using System;
using System.Collections.Generic;
using System.Drawing;

namespace FSC_CNest.Colors
{
    /// <summary>
    /// Prepared class for the best rgb experience
    /// </summary>
    public class RGB
    {
        private Color _color = Color.Blue;
        private Dictionary<char, int> _colorDirection = new();

        /// <summary>
        /// Creates an instance of the RGB class with the start-color of blue
        /// </summary>
        public RGB()
        {
            _colorDirection.Add('r', _color.R < 255 ? 1 : -1);
            _colorDirection.Add('g', _color.G < 255 ? 1 : -1);
            _colorDirection.Add('b', _color.B < 255 ? 1 : -1);
        }

        /// <summary>
        /// Creates an instance of the RGB class with a custom start-color
        /// </summary>
        /// <param name="smoothRgbStartColor">Defines the start-color</param>
        public RGB(Color smoothRgbStartColor) : this()
        {
            _color = smoothRgbStartColor;
        }

        /// <summary>
        /// Creates on each call a new color. Add this into a loop to create a smooth color change
        /// </summary>
        /// <returns>Returns the generated color</returns>
        public Color SmoothRGB()
        {
            var r = _color.R;
            var g = _color.G;
            var b = _color.B;

            updateSmoothRgbDictionary('r', r);
            updateSmoothRgbDictionary('g', g);
            updateSmoothRgbDictionary('b', b);

            r += (byte)_colorDirection['r'];
            g += (byte)_colorDirection['g'];
            b += (byte)_colorDirection['b'];

            _color = Color.FromArgb(_color.A, r, g, b);
            return _color;
        }
        
        private void updateSmoothRgbDictionary(char c, int i)
        {
            if (i == 255 || i == 0)
            {
                _colorDirection[c] *= -1;
            }
        }

        /// <summary>
        /// Creates a random color
        /// </summary>
        /// <returns>Returns the generated color</returns>
        private static Color RandomColor()
        {
            Random random = new();
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }
    }
}
