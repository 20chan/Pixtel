using System.Drawing;

namespace Pix
{
    public interface ILayer
    {
        Point Position { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        (Point, Color)[] GetDrawList();
    }
}
