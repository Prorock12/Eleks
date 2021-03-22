using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.ShapeModels
{
    public class Ellipse : Shape,IEllipse
    {

        public Ellipse(string name) : base(name)
        {
            Width = 100;
            Height = 50;
            Fill = new SolidColorBrush(Colors.Aqua);
        }
    }
}
