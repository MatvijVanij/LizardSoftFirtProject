using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public abstract class AbstractRectangle : AbstractFigure,IMovable
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
        }

        public override void Move(int deltaX, int deltaY,Point point)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }

        public override bool IsSelected(Point point)
        {
            if (point.X >= StartPoint.X && point.X <= EndPoint.X
             && point.Y >= StartPoint.Y && point.Y <= EndPoint.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}