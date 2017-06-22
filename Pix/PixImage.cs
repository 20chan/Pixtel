using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pix
{
    public class PixImage
    {
        public List<ILayer> Layers { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public PixImage(int width, int height)
        {
            Layers = new List<ILayer>();
            Width = width;
            Height = height;
        }
    }
}
