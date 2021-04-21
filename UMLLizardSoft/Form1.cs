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
        bool _isMove = false;
        int _arrowWeight;
        Pen _pen;
        List<AbstractFigure> _abstractFigures;
        IFactory _currentFactory;
        Point _newpoint;
        bool _isSelected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _abstractFigures = new List<AbstractFigure>();
            _arrowWeight = 1;
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
            _currentFactory = new Rectangle1Factory();
            _pen = new Pen(colorDialog1.Color, trackBar1.Value);
            _currentFigure = _currentFactory.Create(_pen);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStepBack.Enabled = true;

            if (_isMove)
            {
                foreach (AbstractFigure a in _abstractFigures)
                {
                    if (a.IsSelected(e.Location))
                    {
                        _currentFigure = a;
                        break;
                    }
                }

                if (_currentFigure != null)
                {
                    _abstractFigures.Remove(_currentFigure);
                    _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    _graphics = Graphics.FromImage(_mainBitmap);
                    _graphics.Clear(Color.White);

                    foreach (AbstractFigure a in _abstractFigures)
                    {
                        a.Draw(_graphics, a.FigurePen);
                    }

                    pictureBox1.Image = _mainBitmap;
                    _newpoint = e.Location;
                }
            }
            else
            {
                _currentFigure = _currentFactory.Create(_pen);
                _currentFigure.StartPoint = e.Location;
            }

            _isButtonPressed = true;
            _isSelected = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
            _mainBitmap = _tmpBitmap;

            if (_currentFigure != null)
            {
                _abstractFigures.Add(_currentFigure);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isButtonPressed && _currentFigure != null)
            {
                if (_isMove)
                {
                    _currentFigure.Move(e.X - _newpoint.X, e.Y - _newpoint.Y, e.Location);
                    _newpoint = e.Location;
                }
                else
                {
                    _currentFigure.EndPoint = e.Location;
                }

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                _currentFigure.Draw(_graphics, _currentFigure.FigurePen);
                pictureBox1.Image = _tmpBitmap;
                //GC.Collect();
            }
            else
            {
                _isButtonPressed = false;
            }
        }

        private void radioButtonAssociation_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowAssociationFactory();
        }

        private void radioButtonInheritance_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowInheritanceFactory();
        }

        private void radioButtonAggregation_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowAggregationFactory();
        }

        private void radioButtonСomposition_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowСompositionFactory();
        }

        private void radioButtonImplementation_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowImplementationFactory();
        }

        private void radioButtonRectangle1_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new Rectangle1Factory();
        }
        private void radioButtonRectangleStack_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new RectangleStackFactory();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            int minWeightValue = bar.Minimum;
            int value = bar.Value;
            _arrowWeight = 1 + minWeightValue + value;
            _pen.Width = trackBar1.Value;
            bar.SetRange(2, 5);
        }

        private void buttonColorPalette_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonColorPalette.BackColor = colorDialog1.Color;
            _pen.Color = colorDialog1.Color;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _abstractFigures.Clear();
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            _currentFigure = null;
            _isMove = true;
        }

        private void StepBack_Click(object sender, EventArgs e)
        {
            if (_abstractFigures.Count > 0)
            {
                _abstractFigures.RemoveAt(_abstractFigures.Count - 1);
                _graphics.Clear(Color.White);

                foreach (AbstractFigure a in _abstractFigures)
                {
                    a.Draw(_graphics, a.FigurePen);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            _currentFigure.SaveElementText(textBox1.Text);
            pictureBox1.Invalidate();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            _isSelected = true;
        }
    }
}