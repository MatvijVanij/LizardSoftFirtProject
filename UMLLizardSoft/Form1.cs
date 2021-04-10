using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        AbstractFigure _currentFigure;
        bool _isButtonPressed = false;
        int arrowWeight;
        Pen pen = new Pen(Color.Black, 3);
        List<AbstractFigure> abstractFigures;
        FigureType _figureType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abstractFigures = new List<AbstractFigure>();
            arrowWeight = 1;
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
            _currentFigure = new Rectangle1();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (_figureType)
            {
                case FigureType.Rectangle1:
                    _currentFigure = new Rectangle1();
                    break;
                case FigureType.ArrowAssociation:
                    _currentFigure = new ArrowAssociation();
                    break;
                case FigureType.ArrowInheritance:
                    _currentFigure = new ArrowInheritance();
                    break;
                case FigureType.ArrowAggregation:
                    _currentFigure = new ArrowAggregation();
                    break;
                case FigureType.ArrowComposition:
                    _currentFigure = new ArrowСomposition();
                    break;
                case FigureType.ArrowImplementation:
                    _currentFigure = new ArrowImplementation();
                    break;
                default:
                    break;
            }
            _currentFigure.StartPoint = e.Location;
            _isButtonPressed = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
            _mainBitmap = _tmpBitmap;
            abstractFigures.Add(_currentFigure);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isButtonPressed)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                _currentFigure.EndPoint = e.Location;
                _currentFigure.Draw(_graphics, pen);
                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }
        }

        private void radioButtonAssociation_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.ArrowAssociation;
        }

        private void radioButtonInheritance_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.ArrowInheritance;
        }

        private void radioButtonAggregation_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.ArrowAggregation;
        }

        private void radioButtonСomposition_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.ArrowComposition;
        }

        private void radioButtonImplementation_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.ArrowImplementation;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Rectangle1;
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }
    }
}