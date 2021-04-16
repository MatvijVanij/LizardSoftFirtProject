using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ArrowAssociationFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new ArrowAssociation()
            {
                FigurePen = pen
            };
        }
    }
}