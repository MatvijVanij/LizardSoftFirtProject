using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        int arrowWeight;

        int x1, y1, x2, y2;
        bool _isButtonPressed = false;
        private delegate void DrawArrow(Pen _pen, int x1, int y1, int x2, int y2);
        DrawArrow drawArrow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _penEnd = new Pen(Color.Red, arrowWeight);                        //Line width of "Implimentation" ArrowBody !ONLY!
            _pen = new Pen(Color.Red, arrowWeight);                           //line width of otherwise
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
            drawArrow = addArrowAsotiation;                     //initialValue
            arrowWeight = 1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //inputAquired!
            _isButtonPressed = true;                                    
            x1 = e.X;
            y1 = e.Y;
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
                x2 = e.X;
                y2 = e.Y;

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                drawArrow.Invoke(_pen, x1, y1, x2, y2);                             //correctDrawings

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }

        }
        public void addArrowImplementation(Pen _pen, int x1, int y1, int x2, int y2)// Имплиментацыя
        {
            double ugol = Math.Atan2(x1 - x2, y1 - y2);
            _penEnd.DashStyle = DashStyle.Dash;

            _graphics.DrawLine(_penEnd, x1, y1, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0)));

            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
            _graphics.DrawLine(_pen, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)), Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
        }

        public void addArrowAsotiation(Pen _pen, int x1, int y1, int x2, int y2)                    //_1 -> old, _2 -> new    pen ~ context
        {
            double ugol = Math.Atan2(x1 - x2, y1 - y2);// Асоциация                                                                                         //ugol ----> angle
            _graphics.DrawLine(_pen, x1, y1, x2, y2);
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
        }

        public void addArrowInheritance(Pen _pen, int x1, int y1, int x2, int y2)//Наследование
        {
            double ugol = Math.Atan2(x1 - x2, y1 - y2);

            _graphics.DrawLine(_pen, x1, y1, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0)));

            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)));
            _graphics.DrawLine(_pen, x2, y2, Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
            _graphics.DrawLine(_pen, Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + ugol)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + ugol)), Convert.ToInt32(x2 + 25 * Math.Sin(ugol - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(ugol - 0.4)));
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



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drawArrow = addArrowAsotiation;                                                 //changeValue
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            drawArrow = addArrowInheritance;                                                 //changeValue
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            drawArrow = addArrowAggregation;                                                 //changeValue
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            drawArrow = addArrowСomposition;                                                 //changeValue
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            drawArrow = addArrowImplementation;                                              //changeValue
        }

        public void AddRectangle(Pen _pen, int firstPoint, int secondPoint)
        {
            int W = x2 - x1;
            int H = y2 - y1;

            _graphics.DrawRectangle(_pen, x1, y1, W, H);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar) sender;
            int minWeightValue = bar.Minimum;
            int maxWeitghValue = bar.Maximum;
            int value = bar.Value;
            arrowWeight = 1 + minWeightValue + value;
            _penEnd = new Pen(Color.Red, arrowWeight);                        //Line width of "Implimentation" ArrowBody !ONLY!
            _pen = new Pen(Color.Red, arrowWeight);                           //line width of otherwise
            bar.SetRange(1, 4);                                               //was 4 --> 1-4
            
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
