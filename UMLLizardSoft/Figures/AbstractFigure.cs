using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public abstract class AbstractFigure : IMovable
    {
        protected string _textClass;
        protected string _textField;
        protected string _textMethod;
        protected int _height = 40;
        protected int _width = 100;
        public List<string> ListForTextClass;
        public List<string> ListForTextField;
        public List<string> ListForTextMethod;
        protected List<ClassDiagramMain> _moduls;
        protected ClassDiagramMain _abstractClassDiagramMain;

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen FigurePen { get; set; }

        public AbstractFigure()
        {
            ListForTextClass = new List<string>();
            ListForTextField = new List<string>();
            ListForTextMethod = new List<string>();
        }

        public abstract void Draw(Graphics graphics, Pen pen);
        public abstract void Move(int deltaX, int deltaY, Point point);
        public abstract bool IsSelected(Point point);
        public abstract void SaveElementTextClass(string text);
        public abstract void SaveElementTextField(string text);
        public abstract void SaveElementTextMethod(string text);
    }
}