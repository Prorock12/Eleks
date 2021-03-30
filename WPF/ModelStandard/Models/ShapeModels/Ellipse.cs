using System.Windows.Media;
using ModelStandard.Interfaces.ShapeModels;

namespace ModelStandard.Models.ShapeModels
{
    public class Ellipse : Shape,IEllipse
    {

        public Ellipse(string name) : base(name)
        {
            Width = 100;
            Height = 50;
            Fill = Colors.Aqua;
        }
    }
}
