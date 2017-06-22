using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Pixtel
{
    public class PixCanvas : Canvas
    {
        public BitmapImage Image { get; set; }

        protected override void OnRender(DrawingContext dc)
        {
            dc.DrawImage(Image, new System.Windows.Rect(0, 0, Image.Width, Image.Height));
            base.OnRender(dc);
        }
    }
}
