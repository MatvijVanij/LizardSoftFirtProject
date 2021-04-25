using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public abstract class AbstractFigure : IMovable
    {
        protected string _textClass;
        protected string _textField;
        protected string _textMethod;
        protected int _heightClass = 27;
        protected int _heightFild = 10;
        protected int _heightMethod = 10;
        protected int _width = 100;
        public List<string> _listForTextClass;
        public List<string> _listForTextField;
        public List<string> _listForTextMethod;
        public List<string> _listForAllText;
        protected ClassDiagramMain _abstractClassDiagramMain;

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen FigurePen { get; set; }

        public AbstractFigure()
        {
            _listForTextClass = new List<string>();
            _listForTextField = new List<string>();
            _listForTextMethod = new List<string>();
        }

        public abstract void Draw(Graphics graphics, Pen pen);
        public abstract void Move(int deltaX, int deltaY, Point point);
        public abstract bool IsSelected(Point point);
        public abstract void SaveElementTextClass(string text);
        public abstract void SaveElementTextField(string text);
        public abstract void SaveElementTextMethod(string text);
    }
}