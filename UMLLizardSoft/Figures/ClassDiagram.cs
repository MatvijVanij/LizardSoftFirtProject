using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ClassDiagram : ClassDiagramMain
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            _moduls = new List<ClassDiagramMain>();
            FigurePen = new Pen(pen.Color, pen.Width);
            Font myFont = new Font("Arial", 12);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            SolidBrush myBrush = new SolidBrush(pen.Color);
            StringFormat strFormat1 = new StringFormat();

            _textClass = string.Empty;
            _textField = string.Empty;
            _textMethod = string.Empty;

            strFormat1.Alignment = StringAlignment.Near;
            strFormat1.LineAlignment = StringAlignment.Near;
            strFormat1.Trimming = StringTrimming.Character;

            //Point point1 = new Point(StartPoint.X, StartPoint.Y);
            //Point point2 = new Point(StartPoint.X + _width, StartPoint.Y);
            //Point point3 = new Point(StartPoint.X + _width, StartPoint.Y + 4 * _height);
            //Point point4 = new Point(StartPoint.X, StartPoint.Y + 4 * _height);
            //Point[] points = { point1, point2, point3, point4 };

            graphics.FillPolygon(solidBrush, GetPointsFillPoligon().ToArray());

            //graphics.FillPolygon(solidBrush, pointsFillPoligon);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, _width, _height);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + _height, _width, _height);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + 2 * _height, _width, 2 * _height);

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

            graphics.DrawString(_textClass, myFont, myBrush, StartPoint.X, StartPoint.Y, strFormat1);
            graphics.DrawString(_textField, myFont, myBrush, StartPoint.X, StartPoint.Y + _height, strFormat1);
            graphics.DrawString(_textMethod, myFont, myBrush, StartPoint.X, StartPoint.Y + 2 * _height, strFormat1);
        }
        protected List<Point> GetPointsFillPoligon()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(StartPoint.X, StartPoint.Y));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y + 4 * _height));
            points.Add(new Point(StartPoint.X, StartPoint.Y + 4 * _height));

            return points;
        }
    }
}