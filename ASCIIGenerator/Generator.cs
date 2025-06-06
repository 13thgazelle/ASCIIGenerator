using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIGenerator
{
    public class Generator
    {
        private string asciiChars = " .-:=+*#";
        public string Generate(string imgLocation, int width, bool reverse)
        {
            if (reverse)
                asciiChars = "#*+=:-. ";
            Bitmap source = new Bitmap(imgLocation);
            StringBuilder result = new StringBuilder();

            int height = (int)(source.Height / (double)source.Width * width);
            Bitmap image = new Bitmap(source, new Size(width: width, height: height));

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    int gray = (int)(0.32 * pixelColor.R + 0.59 * pixelColor.G + 0.11 * pixelColor.B);

                    int index = gray * (asciiChars.Length - 1) / 255;

                    if (index < 0) index = 0;
                    if (index >= asciiChars.Length) index = asciiChars.Length - 1;

                    result.Append(asciiChars[index]);
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
