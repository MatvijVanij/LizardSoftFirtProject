using System.Drawing;
using System.Windows.Forms;

namespace UMLLizardSoft.Figures.SinglePainter
{
    public class Painter
    {
        public Graphics PainterGraphics { get; set; }

        public Pen FigurePen { get; set; }

        private Bitmap _mainbitmap;
        private Bitmap _tmpBitmap;
        private PictureBox _pictureBox;
        private static Painter _painter;

        private Painter()
        {
            FigurePen = new Pen(Color.Black, 3);
        }

        public void SetPictureBox(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _mainbitmap = new Bitmap(_pictureBox.Width,_pictureBox.Height);
            _tmpBitmap = (Bitmap)_mainbitmap.Clone();
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
            _pictureBox.BackColor = Color.White;
            _pictureBox.Image = _tmpBitmap;
        }

        public static Painter GetPainter()
        {
            if (_painter is null)
            {
                _painter = new Painter();
            }

            return _painter;
        }

        public void UpdateTmpBitmap()
        {
            _tmpBitmap = (Bitmap)_mainbitmap.Clone();
        }

        public void SetMainBitmap()
        {
            _mainbitmap = _tmpBitmap;
        }

        public void UpdatePictureBox()
        {
            _pictureBox.Image = _tmpBitmap;
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
        }

        public void Clear()
        {
            _mainbitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
        }
    }
}
