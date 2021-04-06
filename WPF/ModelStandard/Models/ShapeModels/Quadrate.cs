using System.Windows.Media;
using ModelStandard.Interfaces.ShapeModels;

namespace ModelStandard.Models.ShapeModels
{
    public class Quadrate : Shape,IQuadrate
    {

        public Quadrate(string name) : base(name)
        {
            Width = 100;
            Fill = Colors.Tomato;
        }

    }
}
