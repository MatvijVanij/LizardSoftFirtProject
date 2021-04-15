using System;
using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public abstract class AbstractFigure:IMovable
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen FigurePen { get; set; }

        public abstract void Draw(Graphics graphics, Pen pen);

        public abstract void Move(int deltaX, int deltaY);

        public abstract bool IsGrabbing(Point point);
        
    }
}