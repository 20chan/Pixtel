using System;
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
            throw new NotImplementedException();
        }
    }
}
