using System;
using System.Drawing;
using System.Windows.Forms;
using UMLLizardSoft.Arrows;

namespace UMLLizardSoft
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        AbstractArrow _crntArrow;
        bool _isButtonPressed = false;
        int arrowWeight;
        Pen pen = new Pen(Color.Black,3);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrowWeight = 1;
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
            _crntArrow = new ArrowAssociation();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _crntArrow.StartPoint = e.Location;
            _isButtonPressed = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
            _mainBitmap = _tmpBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isButtonPressed)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                _crntArrow.EndPoint = e.Location;
                _crntArrow.Draw(_graphics,pen);
                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowAssociation();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowInheritance();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowAggregation();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowСomposition();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowImplementation();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            int minWeightValue = bar.Minimum;
            int maxWeitghValue = bar.Maximum;
            int value = bar.Value;
            arrowWeight = 1 + minWeightValue + value;
            pen = new Pen(pen.Color, arrowWeight);
            bar.SetRange(1, 10);
        }

        private void buttonColorPalette_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonColorPalette.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
        }

        //public void AddRectangle(Pen _pen, int firstPoint, int secondPoint)
        //{
        //    int W = x2 - x1;
        //    int H = y2 - y1;

        //    _graphics.DrawRectangle(_pen, x1, y1, W, H);
        //}

        //public void AddRectangle1(Pen _pen, int firstPoint, int secondPoint)
        //{
        //    int W = x2 - x1;
        //    int H = y2 - y1;

        //    _graphics.DrawRectangle(_pen, x1, y1, W, H);
        //    _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.2));
        //    _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.5));
        //}

        //public void AddRectangle2(Pen _pen, int firstPoint, int secondPoint)
        //{
        //    int W = x2 - x1;
        //    int H = y2 - y1;

        //    _graphics.DrawRectangle(_pen, x1, y1, W, H);
        //    _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.2));
        //}

        //public void AddRectangle3(Pen _pen, int firstPoint, int secondPoint)
        //{
        //    int W = x2 - x1;
        //    int H = y2 - y1;

        //    _graphics.DrawRectangle(_pen, x1, y1, W, H);
        //    _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.2));
        //    _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.5));
        //    _graphics.DrawRectangle(_pen, x1, y1, W, (int)(H * 0.8));
        //}
    }
}