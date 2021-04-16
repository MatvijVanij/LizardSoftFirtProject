using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLLizardSoft.Factories;
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
        bool isMove = false;
        int arrowWeight;
        Pen pen;
        List<AbstractFigure> abstractFigures;
        FigureType _figureType;

        IFactory _currentFactory;

        Point newpoint;

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
            _currentFactory = new Rectangle1Factory();
            _currentFigure = _currentFactory.Create();
            pen = new Pen(colorDialog1.Color, trackBar1.Value);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                foreach (AbstractFigure a in abstractFigures)
                {
                    if (a.IsGrabbing(e.Location))
                    {
                        _currentFigure = a;
                        break;
                    }
                }

                if (_currentFigure != null)
                {
                    abstractFigures.Remove(_currentFigure);
                    _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    _graphics = Graphics.FromImage(_mainBitmap);
                    _graphics.Clear(Color.White);

                    foreach (AbstractFigure a in abstractFigures)
                    {
                        a.Draw(_graphics, pen);
                    }

                    pictureBox1.Image = _mainBitmap;
                    newpoint = e.Location;
                }
            }
            else
            {
                _currentFigure = _currentFactory.Create();

                _currentFigure.StartPoint = e.Location;
            }

            _isButtonPressed = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
            isMove = false;
            _mainBitmap = _tmpBitmap;

            if (_currentFigure != null)
            {
                abstractFigures.Add(_currentFigure);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isButtonPressed && _currentFigure != null)
            {
                if (isMove)
                {
                    _currentFigure.Move(e.X - newpoint.X, e.Y - newpoint.Y, e.Location);
                    newpoint = e.Location;
                }
                else
                {
                    _currentFigure.EndPoint = e.Location;
                }

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                _currentFigure.Draw(_graphics, pen);

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }
            else
            {
                _isButtonPressed = false;
            }
        }

        private void radioButtonAssociation_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new ArrowAssociationFactory();
        }

        private void radioButtonInheritance_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new ArrowInheritanceFactory();
        }

        private void radioButtonAggregation_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new ArrowAggregationFactory();
        }

        private void radioButtonСomposition_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new ArrowСompositionFactory();
        }

        private void radioButtonImplementation_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new ArrowImplementationFactory();
        }

        private void radioButtonRectangle1_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new Rectangle1Factory();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            int minWeightValue = bar.Minimum;
            int maxWeitghValue = bar.Maximum;
            int value = bar.Value;
            arrowWeight = 1 + minWeightValue + value;
            pen.Width = trackBar1.Value;
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
            abstractFigures.Clear();

            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            _currentFigure = null;
            isMove = true;
        }

        private void StepBack_Click(object sender, EventArgs e)
        {
            if (abstractFigures.Count != 0)
            {
                abstractFigures.RemoveAt(abstractFigures.Count - 1);
                _graphics.Clear(Color.White);

                foreach (AbstractFigure a in abstractFigures)
                {
                    a.Draw(_graphics, pen);
                }

                pictureBox1.Image = _mainBitmap;
            }
            else 
            {
                buttonStepBack.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}