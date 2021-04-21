using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class AbstractRectangle : AbstractFigure,IMovable
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

        public override void SaveElementText(string strText)
        {
            List<string> currentList = new List<string>();
            if (select == EnumSectionRectangle.FirstSection)
            {
                _listForRect1Text.Add(strText);
                currentList = _listForRect1Text;
            }
            else if (select == EnumSectionRectangle.SecondSection)
            {
                _listForRect2Text.Add(strText);
                currentList = _listForRect2Text;
            }
            else if (select == EnumSectionRectangle.ThirdSection)
            {
                _listForRect3Text.Add(strText);
                currentList = _listForRect3Text;
            }
        }

        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            if (point.X >= StartPoint.X && point.X <= EndPoint.X
             && point.Y >= StartPoint.Y + height && point.Y <= EndPoint.Y + width)
            {
                return true;
            }
            if (point.X >= StartPoint.X && point.X <= EndPoint.X
             && point.Y >= StartPoint.Y + 2*height && point.Y <= EndPoint.Y + 2*width)
            {
                return true;
            }
            if (point.X >= StartPoint.X && point.X <= EndPoint.X
             && point.Y >= StartPoint.Y + 3 * height && point.Y <= EndPoint.Y + 3 * width)
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