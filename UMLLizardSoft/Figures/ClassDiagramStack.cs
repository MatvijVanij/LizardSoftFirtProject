using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ClassDiagramStack : ClassDiagramMain
    {
        const int delta = 10;
        const int indent = 5;
        SizeF stringSize = new SizeF();
        Font myFont = new Font("Arial", 10);

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

            ResizeWidth(graphics);
            ResizeClassHeight(graphics);
            graphics.FillPolygon(solidBrush, GetPointsFillPoligonClass().ToArray());
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, _width, _heightClass);

            ResizeFieldHeight(graphics);
            graphics.FillPolygon(solidBrush, GetPointsFillPoligonField().ToArray());
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + _heightClass, _width, _heightFild);

            ResizeMethodHeight(graphics);
            graphics.FillPolygon(solidBrush, GetPointsFillPoligonMethod().ToArray());
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + _heightClass + _heightFild, _width, _heightMethod);

            graphics.DrawString(_textClass, myFont, myBrush, StartPoint.X + indent, StartPoint.Y + indent, strFormat1);
            graphics.DrawString(_textField, myFont, myBrush, StartPoint.X + indent, StartPoint.Y + _heightClass + indent, strFormat1);
            graphics.DrawString(_textMethod, myFont, myBrush, StartPoint.X + indent, StartPoint.Y + _heightClass + _heightFild + indent, strFormat1);

            graphics.FillPolygon(solidBrush, GetPointsSecondStack().ToArray());
            graphics.FillPolygon(solidBrush, GetPointsLastStack().ToArray());

            graphics.DrawPolygon(FigurePen, GetPointsSecondStack().ToArray());
            graphics.DrawPolygon(FigurePen, GetPointsLastStack().ToArray());
        }

        protected List<Point> GetPointsLastStack()
        {
            List<Point> pointspointsLastRectangle = new List<Point>();

            pointspointsLastRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - delta));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - 2 * delta + _heightFild + _heightMethod + _heightClass));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta + _heightMethod + _heightFild + _heightClass));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta + _width, StartPoint.Y - 2 * delta));
            pointspointsLastRectangle.Add(new Point(StartPoint.X - 2 * delta + _width, StartPoint.Y - delta));

            return pointspointsLastRectangle;
        }
        protected List<Point> GetPointsSecondStack()
        {
            List<Point> pointspointsSecondRectangle = new List<Point>();

            pointspointsSecondRectangle.Add(new Point(StartPoint.X, StartPoint.Y));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X, StartPoint.Y - delta + _heightFild + _heightMethod + _heightClass));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - delta + _heightFild + _heightMethod + _heightClass));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta, StartPoint.Y - delta));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta + _width, StartPoint.Y - delta));
            pointspointsSecondRectangle.Add(new Point(StartPoint.X - delta + _width, StartPoint.Y));

            return pointspointsSecondRectangle;
        }

        protected List<Point> GetPointsFillPoligonClass()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(StartPoint.X, StartPoint.Y));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y + _heightClass));
            points.Add(new Point(StartPoint.X, StartPoint.Y + _heightClass));

            return points;
        }
        protected List<Point> GetPointsFillPoligonField()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(StartPoint.X, StartPoint.Y + _heightClass));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y + _heightClass));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y + _heightClass + _heightFild));
            points.Add(new Point(StartPoint.X, StartPoint.Y + _heightClass + _heightFild));

            return points;
        }
        protected List<Point> GetPointsFillPoligonMethod()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(StartPoint.X, StartPoint.Y + _heightClass + _heightFild));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y + _heightClass + _heightFild));
            points.Add(new Point(StartPoint.X + _width, StartPoint.Y + _heightClass + _heightFild + _heightMethod));
            points.Add(new Point(StartPoint.X, StartPoint.Y + _heightClass + _heightFild + _heightMethod));

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
            if (max.Length < _textMethod.Length)
            {
                max = _textMethod;
            }

            return max;
        }
        public void ResizeWidth(Graphics graphics)
        {
            stringSize = graphics.MeasureString(GetMax(), myFont);

            if (stringSize.Width > _width)
            {
                _width = (int)stringSize.Width + 2 * indent;
            }
        }
        public void ResizeClassHeight(Graphics graphics)
        {
            stringSize = graphics.MeasureString(_textClass, myFont);

            if (stringSize.Height > _heightClass)
            {
                _heightClass = (int)stringSize.Height + 2 * indent;
            }
        }
        public void ResizeFieldHeight(Graphics graphics)
        {
            stringSize = graphics.MeasureString(_textField, myFont);

            if (stringSize.Height > _heightFild)
            {
                _heightFild = (int)stringSize.Height + 2 * indent;
            }
        }
        public void ResizeMethodHeight(Graphics graphics)
        {
            stringSize = graphics.MeasureString(_textMethod, myFont);

            if (stringSize.Height > _heightMethod)
            {
                _heightMethod = (int)stringSize.Height + 2 * indent;
            }
        }
    }
}