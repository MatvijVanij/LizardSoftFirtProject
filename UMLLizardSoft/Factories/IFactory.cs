using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public interface IFactory
    {
        AbstractFigure Create(Pen pen);
    }
}