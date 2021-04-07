using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UMLLizardSoft.Arrows;

namespace UMLLizardSoft
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        bool _isButtonPressed = false;

        AbstractArrow _crntArrow;

        int arrowWeight;
        //Pen _pen;
        //Pen _penEnd;


        //Point _pointFirst;
        //Point _pointSecond;

        //int x1, y1, x2, y2;

        //private delegate void DrawArrow(Pen _pen, int x1, int y1, int x2, int y2);
        //DrawArrow drawArrow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //_penEnd = new Pen(Color.Red, arrowWeight);                        //Line width of "Implimentation" ArrowBody !ONLY!
            //_pen = new Pen(Color.Red, arrowWeight);                           //line width of otherwise
            //_graphics = Graphics.FromImage(_mainBitmap);
            //_graphics.Clear(Color.White);
            //pictureBox1.Image = _mainBitmap;
            //drawArrow = addArrowAsotiation;                     //initialValue
            //arrowWeight = 1;

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
            ////inputAquired!
            //_isButtonPressed = true;
            //x1 = e.X;
            //y1 = e.Y;
            //_pointFirst = new Point(x1, y1);
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

                _crntArrow.Draw(_graphics);

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }
            //if (_isButtonPressed)
            //{
            //    x2 = e.X;
            //    y2 = e.Y;
            //    _pointSecond = new Point(x2, y2);

            //    _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            //    _graphics = Graphics.FromImage(_tmpBitmap);

            //    drawArrow.Invoke(_pen, x1, y1, x2, y2);                             //correctDrawings

            //    pictureBox1.Image = _tmpBitmap;
            //    GC.Collect();
            //}
        }
        //public void addArrowImplementation(Pen _pen, int x1, int y1, int x2, int y2)// Имплиментацыя
        //{
        //    //double angle = Math.Atan2(x1 - x2, y1 - y2);
        //    //_penEnd.DashStyle = DashStyle.Dash;

        //    //Point pointSecond = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0)));

        //    //Point point1 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
        //    //Point point2 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));
        //    //Point point3 = _pointSecond;

        //    //Point[] points = { point1, point2, point3 };

        //    //_graphics.DrawLine(_penEnd, _pointFirst, pointSecond);

        //    //_graphics.DrawPolygon(_pen, points);
        //}

        //public void addArrowAssociation(Pen _pen, int x1, int y1, int x2, int y2)                    //_1 -> old, _2 -> new    pen ~ context
        //{
        //    //double angle = Math.Atan2(x1 - x2, y1 - y2);// Асоциация   

        //    //Point pointSecond = new Point(x2, y2);
        //    //Point point1 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
        //    //Point point3 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));
        //    //Point point2 = _pointSecond;
        //    //Point[] points = { point1, point2, point3 };

        //    //_graphics.DrawLine(_pen, _pointFirst, pointSecond);

        //    //_graphics.DrawLines(_pen, points);
        //}

        //public void addArrowInheritance(Pen _pen, int x1, int y1, int x2, int y2)//Наследование
        //{
        //    //double angle = Math.Atan2(x1 - x2, y1 - y2);

        //    //Point pointSecond = new Point(Convert.ToInt32(x2 + 23 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 23 * Math.Cos(angle - 0)));
        //    //Point point1 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
        //    //Point point2 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));
        //    //Point point3 = _pointSecond;

        //    //Point[] points = { point1, point2, point3};

        //    //_graphics.DrawLine(_pen, _pointFirst, pointSecond);

        //    //_graphics.DrawPolygon(_pen, points);
        //}

        //public void addArrowAggregation(Pen _pen, int x1, int y1, int x2, int y2)//Агрегация
        //{
        //    //double angle = Math.Atan2(x1 - x2, y1 - y2);

        //    //Point pointSecond = new Point(Convert.ToInt32(x2 + 50 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(angle - 0)));
        //    //Point point1 = new Point(Convert.ToInt32(x2 + 50 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(angle - 0)));
        //    //Point point2 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
        //    //Point point3 = _pointSecond;
        //    //Point point4 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));

        //    //Point[] points = { point1, point2, point3, point4 };

        //    //_graphics.DrawPolygon(_pen, points);

        //    //_graphics.DrawLine(_pen, _pointFirst, pointSecond);
        //}

        //public void addArrowСomposition(Pen _pen, int x1, int y1, int x2, int y2)//Композицыя
        //{
        //    //SolidBrush solidBrush = new SolidBrush(_pen.Color);
        //    //double angle = Math.Atan2(x1 - x2, y1 - y2);

        //    //Point pointSecond = new Point(Convert.ToInt32(x2 + 50 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(angle - 0)));
        //    //Point point1 = new Point(Convert.ToInt32(x2 + 50 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(angle - 0)));
        //    //Point point2 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
        //    //Point point3 = _pointSecond;
        //    //Point point4 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));
        //    //Point[] points = { point1, point2, point3, point4 };

        //    //_graphics.DrawLine(_pen, _pointFirst, pointSecond);

        //    //_graphics.DrawPolygon(_pen, points);

        //    //_graphics.FillClosedCurve(solidBrush, points);
        //}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowAssociation();                                                //changeValue
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowInheritance();                                                 //changeValue
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowAggregation();                                                 //changeValue
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowСomposition();                                                 //changeValue
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _crntArrow = new ArrowImplementation();                                              //changeValue
        }

        //public void AddRectangle(Pen _pen, int firstPoint, int secondPoint)
        //{
        //    int W = x2 - x1;
        //    int H = y2 - y1;

        //    _graphics.DrawRectangle(_pen, x1, y1, W, H);
        //}

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            int minWeightValue = bar.Minimum;
            int maxWeitghValue = bar.Maximum;
            int value = bar.Value;
            arrowWeight = 1 + minWeightValue + value;
            //_penEnd = new Pen(_pen.Color, arrowWeight);                        //Line width of "Implimentation" ArrowBody !ONLY!
            pen = new Pen(pen.Color, arrowWeight);                           //line width of otherwise
            bar.SetRange(1, 5);                                               //was 4 --> 1-5

        }

        private void buttonColorPalette_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonColorPalette.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
        }

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
