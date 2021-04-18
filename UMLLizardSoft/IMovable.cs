using System.Drawing;

namespace UMLLizardSoft
{
    public interface IMovable
    {
        bool IsSelected(Point point);

        void Move(int deltaX, int deltaY,Point point );
    }
}