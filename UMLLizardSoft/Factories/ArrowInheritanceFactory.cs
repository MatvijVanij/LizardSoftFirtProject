using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ArrowInheritanceFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new ArrowInheritance()
            {
                FigurePen = pen
            };
        }
    }
}