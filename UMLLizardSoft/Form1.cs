using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UMLLizardSoft.Factories;
using UMLLizardSoft.Figures;
using UMLLizardSoft.Helpers;

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
        string _json;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string filePath)
        {
            InitializeComponent();
            _json = File.ReadAllText(filePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _arrowWeight = 1;
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            if (string.IsNullOrEmpty(_json))
            {
                _abstractFigures = new List<AbstractFigure>();
            }
            else
            {
                var serializationHelper = new SerializationHelper();
                _abstractFigures = serializationHelper.Deserialize(_json, _graphics);
            }

            pictureBox1.Image = _mainBitmap;
            _currentFactory = new ClassDiagramFactory();
            _pen = new Pen(colorDialog1.Color, trackBar1.Value);
            _currentFigure = _currentFactory.Create(_pen);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
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
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
            _mainBitmap = _tmpBitmap;

            if (_currentFigure != null)
            {
                _abstractFigures.Add(_currentFigure);
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
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
                GC.Collect();
            }
            else
            {
                _isButtonPressed = false;
            }
        }

        private void RadioButtonAssociation_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowAssociationFactory();
        }

        private void RadioButtonInheritance_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowInheritanceFactory();
        }

        private void RadioButtonAggregation_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowAggregationFactory();
        }

        private void RadioButtonСomposition_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowСompositionFactory();
        }

        private void RadioButtonImplementation_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ArrowImplementationFactory();
        }

        private void RadioButtonRectangle1_CheckedChanged(object sender, EventArgs e)
        {
            _isMove = false;
            _currentFactory = new ClassDiagramFactory();
        }

        private void RadioButtonRectangleStack_CheckedChanged(object sender, EventArgs e)
        {
            _currentFactory = new ClassDiagramStackFactory();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            int minWeightValue = bar.Minimum;
            int value = bar.Value;
            _arrowWeight = 1 + minWeightValue + value;
            _pen.Width = trackBar1.Value;
            bar.SetRange(2, 5);
        }

        private void ButtonColorPalette_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonColorPalette.BackColor = colorDialog1.Color;
            _pen.Color = colorDialog1.Color;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            _abstractFigures.Clear();
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            _currentFigure = null;
            _isMove = true;
            pictureBox1.Invalidate();
        }

        private void ButtonStepBack_Click(object sender, EventArgs e)
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

        private void ButtonClass_Click(object sender, EventArgs e)
        {
            if (_currentFigure is ClassDiagramMain)
            {
                _currentFigure.SaveElementTextClass(textBox1.Text);
                _currentFigure.Draw(_graphics, _currentFigure.FigurePen);
                pictureBox1.Invalidate();
            }
        }

        private void ButtonField_Click(object sender, EventArgs e)
        {
            if (_currentFigure is ClassDiagramMain)
            {
                _currentFigure.SaveElementTextField(textBox1.Text);
                _currentFigure.Draw(_graphics, _currentFigure.FigurePen);
                pictureBox1.Invalidate();
            }
        }

        private void ButtonMethod_Click(object sender, EventArgs e)
        {
            if (_currentFigure is ClassDiagramMain)
            {
                _currentFigure.SaveElementTextMethod(textBox1.Text);
                _currentFigure.Draw(_graphics, _currentFigure.FigurePen);
                pictureBox1.Invalidate();
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            var serializationHelper = new SerializationHelper();
            saveFileDialog.Filter = "Lzrd files(*.lzrd)|*.lzrd";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog.FileName;
            string fileText = File.ReadAllText(filename);

            if (string.IsNullOrEmpty(fileText))
                return;

            _json = fileText;
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            _abstractFigures = serializationHelper.Deserialize(_json, _graphics);
            pictureBox1.Image = _mainBitmap;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var serializationHelper = new SerializationHelper();
            var serializedValue = serializationHelper.Serialize(_abstractFigures);
            saveFileDialog.Filter = "Lzrd files(*.lzrd)|*.lzrd";
            saveFileDialog.FileName = "Untitled.lzrd";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, serializedValue);
        }

        private void ButtonSaveAsImage_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JPG Image(*.jpeg)|*.jpg|BMP Image(*.bmp)|*.bmp";
            saveFileDialog.Title = "Save Image";
            saveFileDialog.FileName = "Untitled.jpg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}