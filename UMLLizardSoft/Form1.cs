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
        Pen _penWhite;

        int x1, y1, x2, y2;
        bool _isButtonPressed = false;
        private Brush redBrush;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _penEnd = new Pen(Color.Red, 4);
            _pen = new Pen(Color.Red, 4);
            _penWhite = new Pen(Color.White, 4);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isButtonPressed = true;
            if (_isButtonPressed)
            {
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

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                AddRectangle(_pen, x1, y1);

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }

        }
        public void addArrowImplementation(Pen _pen, int x1, int y1, int x2, int y2)// Имплиментацыя
        {
            double ugol = Math.Atan2(x1 - x2, y1 - y2);
            _pen.DashStyle = DashStyle.Dash;

            _graphics.DrawLine(_pen, x1, y1, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0)));
            _graphics.DrawLine(_penEnd, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_penEnd, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
            _graphics.DrawLine(_penEnd, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)), Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
        }

        public void addArrowAsotiation(Pen _pen, int x1, int y1, int x2, int y2)
        {
            double ugol = Math.Atan2(x1 - x2, y1 - y2);// Асоциация
            _graphics.DrawLine(_pen, x1, y1, x2, y2);
            _graphics.DrawLine(_penEnd, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_penEnd, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
        }

        public void addArrowInheritance(Pen _pen, int x1, int y1, int x2, int y2)//Наследование
        {
            double ugol = Math.Atan2(x1 - x2, y1 - y2);
            _graphics.DrawLine(_pen, x1, y1, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0)));
            _graphics.DrawLine(_penEnd, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_penEnd, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
            _graphics.DrawLine(_penEnd, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)), Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
        }

        public void addArrowAggregation(Pen _pen, int x1, int y1, int x2, int y2)//Агрегация
        {
            double ugol = Math.Atan2(x1 - x2, y1 - y2);
            _graphics.DrawLine(_pen, x1, y1, Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)));
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
            _graphics.DrawLine(_pen, Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)), Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_pen, Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)), Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
        }

        public void addArrowСomposition(Pen _pen, int x1, int y1, int x2, int y2)//Композицыя
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            double ugol = Math.Atan2(x1 - x2, y1 - y2);

            _graphics.DrawLine(_pen, x1, y1, Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)));
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
            _graphics.DrawLine(_pen, Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)), Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)));
            _graphics.DrawLine(_pen, Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)), Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));

            Point point1 = new Point(Convert.ToInt32(x2 + 50 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(ugol - 0)));
            Point point2 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            Point point3 = new Point(x2, y2);
            Point point4 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
            Point[] points = { point1, point2, point3, point4 };

            _graphics.FillClosedCurve(redBrush, points);
        }

        public void AddRectangle(Pen _pen, int firstPoint, int secondPoint)
        {
            int W = x2 - x1;
            int H = y2 - y1;

            _graphics.DrawRectangle(_pen, x1, y1, W, H);
        }

        public void AddRectangle1(Pen _pen, int firstPoint, int secondPoint)
        {
            int W = x2 - x1;
            int H = y2 - y1;

            _graphics.DrawRectangle(_pen, x1, y1, W, H);
            _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.2));
            _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.5));
        }

        public void AddRectangle2(Pen _pen, int firstPoint, int secondPoint)
        {
            int W = x2 - x1;
            int H = y2 - y1;

            _graphics.DrawRectangle(_pen, x1, y1, W, H);
            _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.2));

        }

        public void AddRectangle3(Pen _pen, int firstPoint, int secondPoint)
        {
            int W = x2 - x1;
            int H = y2 - y1;

            _graphics.DrawRectangle(_pen, x1, y1, W, H);
            _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.2));
            _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.5));
            _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.8));

        }
               

    }
}
