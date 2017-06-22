using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.IO;
using Pix;

namespace Pixtel
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Editor : Window
    {
        private PixImage _image;

        public Editor()
        {
            InitializeComponent();
            _image = new PixImage(100, 100);
            var layer = new ColorMatrix(_image.Width, _image.Height);
            layer.Bitmap.SetPixel(50, 50, System.Drawing.Color.Blue);
            _image.Layers.Add(layer);
            DrawImage();
        }

        public void DrawImage()
        {
            Bitmap res = new Bitmap(_image.Width, _image.Height);
            foreach (var layer in _image.Layers)
            {
                var points = layer.GetDrawList();
                foreach ((var p, var c) in points)
                    res.SetPixel(p.X, p.Y, c);
            }

            BitmapImage bitmapimage = new BitmapImage();
            using (MemoryStream memory = new MemoryStream())
            {
                res.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
            }

            this.DrawArea.Image = bitmapimage;
        }
    }
}
