using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UMLLizardSoft.Figures;
using System.Drawing;
using UMLLizardSoft.Factories;

namespace UMLLizardSoft.Helpers
{
    class SerializationHelper
    {
        public string Serialize(List<AbstractFigure> abstractFigures)
        {
            List<ISerializable> serializables = new List<ISerializable>();

            foreach (var figure in abstractFigures)
            {
                var figureObject = new Figure();
                figureObject.StartPoint = figure.StartPoint;
                figureObject.EndPoint = figure.EndPoint;
                figureObject.Color = figure.FigurePen.Color;
                figureObject.Width = figure.FigurePen.Width;
                figureObject.Type = figure.GetType().ToString();
                figureObject.ListForTextClass = figure.ListForTextClass;
                figureObject.ListForTextField = figure.ListForTextField;
                figureObject.ListForTextMethod = figure.ListForTextMethod;

                serializables.Add(figureObject);
            }

            return JsonConvert.SerializeObject(serializables);
        }

        public List<AbstractFigure> Deserialize(string json, Graphics graphics)
        {
            if (string.IsNullOrEmpty(json) || graphics == null)
                return null;

            var listOfFigures = JsonConvert.DeserializeObject<List<Figure>>(json);

            List<AbstractFigure> abstractFigures = new List<AbstractFigure>();

            foreach(var figure in listOfFigures)
            {
                Pen pen = new Pen(figure.Color, figure.Width);

                if (figure.Type == typeof(ArrowAggregation).ToString())
                {
                    var arrow = new ArrowAggregationFactory().Create(pen);
                    arrow.StartPoint = figure.StartPoint;
                    arrow.EndPoint = figure.EndPoint;

                    abstractFigures.Add(arrow);

                    arrow.Draw(graphics, pen);
                }
                if (figure.Type == typeof(ArrowAssociation).ToString())
                {
                    var arrow = new ArrowAssociationFactory().Create(pen);
                    arrow.StartPoint = figure.StartPoint;
                    arrow.EndPoint = figure.EndPoint;

                    abstractFigures.Add(arrow);

                    arrow.Draw(graphics, pen);
                }
                if (figure.Type == typeof(ArrowInheritance).ToString())
                {
                    var arrow = new ArrowInheritanceFactory().Create(pen);

                    arrow.StartPoint = figure.StartPoint;
                    arrow.EndPoint = figure.EndPoint;

                    abstractFigures.Add(arrow);

                    arrow.Draw(graphics, pen);
                }
                if (figure.Type == typeof(ArrowImplementation).ToString())
                {
                    var arrow = new ArrowImplementationFactory().Create(pen);
                    arrow.StartPoint = figure.StartPoint;
                    arrow.EndPoint = figure.EndPoint;

                    abstractFigures.Add(arrow);

                    arrow.Draw(graphics, pen);
                }
                if (figure.Type == typeof(ArrowСomposition).ToString())
                {
                    var arrow = new ArrowСompositionFactory().Create(pen);
                    arrow.StartPoint = figure.StartPoint;
                    arrow.EndPoint = figure.EndPoint;

                    abstractFigures.Add(arrow);

                    arrow.Draw(graphics, pen);
                }
                if (figure.Type == typeof(ClassDiagram).ToString())
                {
                    var box = new ClassDiagramFactory().Create(pen);
                    box.StartPoint = figure.StartPoint;
                    box.EndPoint = figure.EndPoint;
                    box.ListForTextClass = figure.ListForTextClass;
                    box.ListForTextField = figure.ListForTextField;
                    box.ListForTextMethod = figure.ListForTextMethod;

                    abstractFigures.Add(box);

                    box.Draw(graphics, pen);
                }
                if (figure.Type == typeof(ClassDiagramStack).ToString())
                {
                    var box = new ClassDiagramStackFactory().Create(pen);
                    box.StartPoint = figure.StartPoint;
                    box.EndPoint = figure.EndPoint;
                    box.ListForTextClass = figure.ListForTextClass;
                    box.ListForTextField = figure.ListForTextField;
                    box.ListForTextMethod = figure.ListForTextMethod;

                    abstractFigures.Add(box);

                    box.Draw(graphics, pen);
                }
            }

            return abstractFigures;
        }
    }
}
