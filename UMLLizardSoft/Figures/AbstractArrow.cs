using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Figures
{
    public class AbstractArrow : AbstractFigure
    {
        public override void Draw(Graphics graphics, Pen pen)
        {

        }
        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            int middle = (StartPoint.X + EndPoint.X) / 2;
            points.Add(new Point(middle, StartPoint.Y));
            points.Add(new Point(middle, EndPoint.Y));
            points.Add(EndPoint);

            return points;
        }

        public void DrawingDelta()
        {
            if (Math.Abs(StartPoint.X - EndPoint.X) < 30)
            {
                EndPoint = new Point(StartPoint.X, EndPoint.Y);
            }
            if (Math.Abs(StartPoint.Y - EndPoint.Y) < 30)
            {
                EndPoint = new Point(EndPoint.X, StartPoint.Y);
            }
        }

    }
}
