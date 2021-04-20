using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ArrowAssociationFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            var arrowAssociation = ArrowAssociation.Create();
            arrowAssociation.FigurePen = pen;

            return arrowAssociation;
        }
    }
}