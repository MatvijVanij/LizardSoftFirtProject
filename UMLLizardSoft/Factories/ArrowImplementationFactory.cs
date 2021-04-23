using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ArrowImplementationFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new ArrowImplementation()
            {
                FigurePen = pen
            };
        }
    }
}