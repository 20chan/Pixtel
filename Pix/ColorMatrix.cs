using System;
using System.Drawing;

namespace Pix
{
    public class ColorMatrix : Matrix<Color>
    {
        public ColorMatrix(int width, int height) : base(width, height)
        {

        }

        public static ColorMatrix Resize(ColorMatrix original, int width, int height)
        {
            if (original.Width == width && original.Height == height)
                return original;

            throw new NotImplementedException();
        }

        public static Image ToImage(ColorMatrix original)
            => ToImage(original, original.Width, original.Height);

        public static Image ToImage(ColorMatrix original, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            ColorMatrix resized = Resize(original, width, height);

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    b.SetPixel(x, y, original.GetElement(x, y));

            return b;
        }
    }
}
