using ModelStandard.Interfaces.ShapeModels;
using System.Windows.Media;

namespace ModelStandard.Models.ShapeModels
{
    public class Ellipse : Shape, IEllipse
    {
        public Ellipse(string name) : base(name)
        {
            Width = 100;
            Height = 50;
            Fill = Colors.Aqua;
        }
    }
}