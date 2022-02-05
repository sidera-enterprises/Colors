using System;
using System.Drawing;
using System.Globalization;

namespace Colors
{
    public static class ColorConvert
    {
        /// <summary>
        /// Converts RGB values to a hexadecimal representation of the
        /// same color.
        /// </summary>
        /// <param name="red">The red component of the color.</param>
        /// <param name="green">The green component of the color.</param>
        /// <param name="blue">The blue component of the color.</param>
        /// <returns>
        /// A string value containing the hex color code.
        /// </returns>
        public static string RgbToHex(int red, int green, int blue)
        {
            string r, g, b;

            r = red.ToString("X").PadLeft(2, '0');
            g = green.ToString("X").PadLeft(2, '0');
            b = blue.ToString("X").PadLeft(2, '0');

            return string.Format("#{0}{1}{2}", r, g, b);
        }

        /// <summary>
        /// Converts RGB values to a set of values representing the
        /// color's hue, saturation, and vibrance (HSV).
        /// </summary>
        /// <param name="red">The red component of the color.</param>
        /// <param name="green">The green component of the color.</param>
        /// <param name="blue">The blue component of the color.</param>
        /// <returns>
        /// An array of numbers, each representing a component of the
        /// HSV values created from the color's RGB components.
        /// </returns>
        public static int[] RgbToHsv(int red, int green, int blue)
        {
            int[] hsv = new int[3];

            Color color = Color.FromArgb(red, green, blue);

            hsv[0] = (int)color.GetHue();
            hsv[1] = (int)(100 * color.GetSaturation());
            hsv[2] = (int)(100 * color.GetBrightness());

            return hsv;
        }


        /// <summary>
        /// Converts RGB values to a set of values representing the
        /// color's cyan, magenta, yellow, and black key (CMYK) components,
        /// which are used for measuring ink and toner usage in printing.
        /// </summary>
        /// <param name="red">The red component of the color.</param>
        /// <param name="green">The green component of the color.</param>
        /// <param name="blue">The blue component of the color.</param>
        /// <returns>
        /// An array of numbers, each representing a component of the
        /// CMYK values created from the color's RGB components.
        /// </returns>
        public static int[] RgbToCmyk(int red, int green, int blue)
        {
            int[] cmyk = new int[4];

            float r, g, b;
            r = red / 255f;
            g = green / 255f;
            b = blue / 255f;

            float c, m, y, k;

            k = Math.Min(1 - r, Math.Min(1 - g, 1 - b));
            c = (1 - r - k) / (1 - k);
            m = (1 - g - k) / (1 - k);
            y = (1 - b - k) / (1 - k);

            if (r == 0 && g == 0 && b == 0)
                c = m = y = 0;

            cmyk[0] = (int)(100 * c);
            cmyk[1] = (int)(100 * m);
            cmyk[2] = (int)(100 * y);
            cmyk[3] = (int)(100 * k);

            return cmyk;
        }

        public static Color FromRgb(string rgb)
        {
            const string PREFIX_RGB = "rgb";
            const string PREFIX_RGBA = "rgba";

            string rgbf = rgb.Trim().ToLower().Replace(" ", "");
            if (rgbf.StartsWith(PREFIX_RGBA))
                rgbf = rgbf.Substring(PREFIX_RGBA.Length).Replace("(", "").Replace(")", "");
            else if (rgbf.StartsWith(PREFIX_RGB))
                rgbf = rgbf.Substring(PREFIX_RGB.Length).Replace("(", "").Replace(")", "");

            string[] channels = rgbf.Split(',');

            int red = int.Parse(channels[0].ToString());
            int green = int.Parse(channels[1].ToString());
            int blue = int.Parse(channels[2].ToString());

            return Color.FromArgb(red, green, blue);
        }

        public static Color FromRgb(int red, int green, int blue)
        {
            red = Math.Min(0, Math.Max(red, 255));
            green = Math.Min(0, Math.Max(green, 255));
            blue = Math.Min(0, Math.Max(blue, 255));

            return Color.FromArgb(red, green, blue);
        }

        public static Color FromHex(string hex)
        {
            string hexf = hex.Trim();
            if (hexf.StartsWith("#"))
                hexf = hexf.Substring(1);

            string rhex = hexf.Substring(0, 2);
            string ghex = hexf.Substring(2, 2);
            string bhex = hexf.Substring(4, 2);

            int red = int.Parse(rhex, NumberStyles.HexNumber);
            int green = int.Parse(ghex, NumberStyles.HexNumber);
            int blue = int.Parse(bhex, NumberStyles.HexNumber);

            return Color.FromArgb(red, green, blue);
        }

        public static bool IsColorName(string name)
        {
            try
            {
                Array colors = Enum.GetValues(typeof(KnownColor));
                foreach (KnownColor kc in colors)
                {
                    string n = kc.ToString();

                    if (n.Trim().ToLower() == name.Trim().ToLower())
                    {
                        Color c = Color.FromName(name);
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsRgb(string rgb)
        {
            try
            {
                const string PREFIX_RGB = "rgb";
                const string PREFIX_RGBA = "rgba";

                string rgbf = rgb.Trim().ToLower().Replace(" ", "");
                if (rgbf.StartsWith(PREFIX_RGBA))
                    rgbf = rgbf.Substring(PREFIX_RGBA.Length).Replace("(", "").Replace(")", "");
                else if (rgbf.StartsWith(PREFIX_RGB))
                    rgbf = rgbf.Substring(PREFIX_RGB.Length).Replace("(", "").Replace(")", "");

                string[] channels = rgbf.Split(',');

                int red = int.Parse(channels[0].ToString());
                int green = int.Parse(channels[1].ToString());
                int blue = int.Parse(channels[2].ToString());

                Color c = Color.FromArgb(red, green, blue);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsHex(string hex)
        {
            try
            {
                string hexf = hex.Trim().ToLower();
                if (hexf.StartsWith("#"))
                    hexf = hexf.Substring(1);

                string rhex = hexf.Substring(0, 2);
                string ghex = hexf.Substring(2, 2);
                string bhex = hexf.Substring(4, 2);

                int red = int.Parse(rhex, NumberStyles.HexNumber);
                int green = int.Parse(ghex, NumberStyles.HexNumber);
                int blue = int.Parse(bhex, NumberStyles.HexNumber);

                Color c = Color.FromArgb(red, green, blue);

                return true;
            }
            catch { return false; }
        }
    }
}
