using System;
using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public abstract class AbstractFigure : IMovable
    {
        protected string text1;
        protected string text2;
        protected string text3;
        protected List<string> _listForRect1Text;
        protected List<string> _listForRect2Text;
        protected List<string> _listForRect3Text;
        protected List<ClassDiagramMain> _moduls;
        protected ClassDiagramMain _abstractRectangle;
        protected int height = 40;
        protected int width = 100;

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen FigurePen { get; set; }

        public AbstractFigure()
        {
            _listForRect1Text = new List<string>(); 
            _listForRect2Text = new List<string>(); 
            _listForRect3Text = new List<string>(); 
        }

        public abstract void Draw(Graphics graphics, Pen pen);
        public abstract void Move(int deltaX, int deltaY, Point point);
        public abstract bool IsSelected(Point point);
        public abstract void SaveElementTextClass(string text);
        public abstract void SaveElementTextField(string text);
        public abstract void SaveElementTextMethod(string text);
    }
}