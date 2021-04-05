using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLLizardSoft
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen _pen;
        Pen _penEnd;
        Point _mouseStart;

        int x1, y1, x2, y2;
        bool _isButtonPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _penEnd = new Pen(Color.Red, 3);
            _pen = new Pen(Color.Red, 3);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isButtonPressed = true;
            if (_isButtonPressed)
            {
                _mouseStart = e.Location;
                x1 = e.X;
                y1 = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isButtonPressed)
            {
                x2 = e.X;
                y2 = e.Y;

                _pen.DashStyle = DashStyle.Dash;


                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                _graphics.DrawLine(_pen, x1, y1, x2, y2);

                double ugol = Math.Atan2(x1 - x2, y1 - y2);

                _graphics.DrawLine(_penEnd,x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.3 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.3 + ugol)));
                _graphics.DrawLine(_penEnd, x2,y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.3)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.3)));
                _graphics.DrawLine(_penEnd, Convert.ToInt32(x2 + 25 * Math.Sin(0.3 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.3 + ugol)), Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.3)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.3)));
                
                pictureBox1.Image = _tmpBitmap;
                GC.Collect();

            }

        }
    }
}
