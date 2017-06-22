using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace Pix
{
    public class ColorMatrix : ILayer
    {
        public Point Position { get; set; }
        public int Width { get => Bitmap.Width; set { throw new NotImplementedException("Resize _data"); } }
        public int Height { get => Bitmap.Height; set { throw new NotImplementedException(); } }

        public Bitmap Bitmap;

        public ColorMatrix(int width, int height)
        {
            Bitmap = new Bitmap(width, height);
        }

        public (Point, Color)[] GetDrawList()
        {
            return GetDrawListLazy().ToArray();
        }

        private IEnumerable<(Point, Color)> GetDrawListLazy()
        {
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                    yield return (new Point(x, y), Bitmap.GetPixel(x, y));
        }
    }
}
