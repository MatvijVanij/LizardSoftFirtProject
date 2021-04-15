using System;
using System.Drawing;


namespace UMLLizardSoft.Figures
{
    public class Rectangle1 :AbstractRectangle
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            int height = EndPoint.Y - StartPoint.Y;
            int width = EndPoint.X - StartPoint.X;

            graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, width, height);
            //graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, width, (int)(height * 0.18));
        }
    }
}
