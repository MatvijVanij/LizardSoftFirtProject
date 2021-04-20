using System.Drawing;
using UMLLizardSoft.Figures;
namespace UMLLizardSoft.Factories
{
    public class Rectangle1Factory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            var rectangle = Rectangle1.Create();
            rectangle.FigurePen = pen;

            return rectangle;
        }
    }
}