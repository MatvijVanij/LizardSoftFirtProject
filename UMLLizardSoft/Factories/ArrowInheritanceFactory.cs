using System.Drawing;
using UMLLizardSoft.Figures;
namespace UMLLizardSoft.Factories
{
    public class ArrowInheritanceFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            var arrowInheritance = ArrowInheritance.Create();
            arrowInheritance.FigurePen = pen;

            return arrowInheritance;
        }
    }
}