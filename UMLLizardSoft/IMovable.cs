using System.Drawing;


namespace UMLLizardSoft
{
    public interface IMovable
    {
        bool IsGrabbing(Point point);

        void Move(int deltaX, int deltaY,Point point );
    }
}
