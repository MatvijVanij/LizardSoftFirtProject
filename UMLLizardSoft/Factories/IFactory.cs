using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public interface IFactory
    {
        AbstractFigure Create();
    }
}
