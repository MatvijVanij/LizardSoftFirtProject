using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ClassDiagramStack : ClassDiagramMain
    {
        int delta = 10;
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

            Point pointFillPoligon1 = new Point(StartPoint.X, StartPoint.Y);
            Point pointFillPoligon2 = new Point(StartPoint.X + _width, StartPoint.Y);
            Point pointFillPoligon3 = new Point(StartPoint.X + _width, StartPoint.Y + 4 * _height);
            Point pointFillPoligon4 = new Point(StartPoint.X, StartPoint.Y + 4 * _height);
            Point[] pointsFillPoligon = { pointFillPoligon1, pointFillPoligon2, pointFillPoligon3, pointFillPoligon4 };

            graphics.FillPolygon(solidBrush, pointsFillPoligon);

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

            graphics.DrawPolygon(FigurePen, GetPointsSecondStack().ToArray());
            graphics.DrawPolygon(FigurePen, GetPointsLastStack().ToArray());
        }

        protected List<Point> GetPointsLastStack()
        {
            List<Point> pointspointsLastRectangle = new List<Point>();

            pointspointsLastRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - delta));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - 2 * delta + 4 * _height));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta + 4 * _height));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta + _width, StartPoint.Y - 2 * delta));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta + _width, StartPoint.Y - delta));

            return pointspointsLastRectangle;
        }
        protected List<Point> GetPointsSecondStack()
        {
            List<Point> pointspointsSecondRectangle = new List<Point>();

            pointspointsSecondRectangle.Add(new Point(StartPoint.X, StartPoint.Y));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X, StartPoint.Y - delta + 4 * _height));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - delta + 4 * _height));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - delta));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta + _width, StartPoint.Y - delta));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta + _width, StartPoint.Y));

            return pointspointsSecondRectangle;
        }
    }
}