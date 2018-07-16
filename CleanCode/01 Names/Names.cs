using System.Drawing;

namespace CleanCode.GraphicEditor
{
    public class ImageTypeEditor
    {
        public Bitmap BitmapDrawer(string filename)
        {
            var bitmap = new Bitmap(filename);
            var graphic = Graphics.FromImage(bitmap);
            graphic.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            graphic.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            graphic.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitmap;
        }
    }
}
