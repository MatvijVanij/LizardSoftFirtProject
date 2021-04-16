using System.Drawing;
using UMLLizardSoft.Figures;
namespace UMLLizardSoft.Factories
{
    public class Rectangle1Factory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new Rectangle1() 
            { 
                FigurePen = pen 
            };
        }
    }
}