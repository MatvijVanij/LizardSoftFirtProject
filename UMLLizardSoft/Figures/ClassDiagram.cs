﻿using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ClassDiagram : ClassDiagramMain
    {
        int indent = 5;
        SizeF stringSize = new SizeF();
        Font myFont = new Font("Arial", 12);
        public override void Draw(Graphics graphics, Pen pen)
        {
            FigurePen = new Pen(pen.Color, pen.Width);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            SolidBrush myBrush = new SolidBrush(pen.Color);
            StringFormat strFormat1 = new StringFormat();

            _textClass = string.Empty;
            _textField = string.Empty;
            _textMethod = string.Empty;

            strFormat1.Alignment = StringAlignment.Near;
            strFormat1.LineAlignment = StringAlignment.Near;
            strFormat1.Trimming = StringTrimming.Character;

            foreach (var strText in _listForTextClass)
            {
                _textClass = strText;
            }

            foreach (var strText in _listForTextField)
            {
                _textField = strText;
            }

            foreach (var strText in _listForTextMethod)
            {
                _textMethod = strText;
            }

            Resize(graphics);

            graphics.FillPolygon(solidBrush, GetPointsFillPoligon().ToArray());
            
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, _width, _height);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + _height, _width, _height);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + 2 * _height, _width, _height);
            
            graphics.DrawString(_textClass, myFont, myBrush, StartPoint.X + indent, StartPoint.Y + indent, strFormat1);
            graphics.DrawString(_textField, myFont, myBrush, StartPoint.X + indent, StartPoint.Y + _height + indent, strFormat1);
            graphics.DrawString(_textMethod, myFont, myBrush, StartPoint.X + indent, StartPoint.Y + 2 * _height + indent, strFormat1);
        }

        protected List<Point> GetPointsFillPoligon()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(StartPoint.X, StartPoint.Y));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y + 3 * _height));
            points.Add(new Point(StartPoint.X, StartPoint.Y + 3 * _height));

            return points;
        }

        public string GetMax()
        {
            string max;
            max = _textClass;
            if (max.Length < _textField.Length)
            {
                max = _textField;
            }
            else if (max.Length < _textMethod.Length)
            {
                max = _textMethod;
            }

            return max;
        }
        public void Resize(Graphics graphics)
        {
            stringSize = graphics.MeasureString(GetMax(), myFont);

            if (stringSize.Width > _width)
            {
                _width = (int)stringSize.Width + 2 * indent;

            }
            if (stringSize.Height > _height)
            {
                _height = (int)stringSize.Height + 2 * indent;
            }
        }
    }
}