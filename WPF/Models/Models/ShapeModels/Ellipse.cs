using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.Models.ShapeModels
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
