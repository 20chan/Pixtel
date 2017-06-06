using System;
using System.Drawing;

namespace Pix
{
    public class ColorMatrix : ILayer
    {
        public Point Position { get; set; }
        public int Width { get => _data.Width; set { throw new NotImplementedException("Resize _data"); } }
        public int Height { get => _data.Height; set { throw new NotImplementedException(); } }

        private Bitmap _data;

        public ColorMatrix(int width, int height)
        {
            _data = new Bitmap(width, height);
        }
    }
}
