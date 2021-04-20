using System.Drawing;
using UMLLizardSoft.Figures;
namespace UMLLizardSoft.Factories
{
    public class ArrowImplementationFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            var arrowImplementation = ArrowImplementation.Create();
            arrowImplementation.FigurePen = pen;

            return arrowImplementation;
        }
    }
}