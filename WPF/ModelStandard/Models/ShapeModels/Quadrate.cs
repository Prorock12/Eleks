using ModelStandard.Interfaces.ShapeModels;
using System.Windows.Media;

namespace ModelStandard.Models.ShapeModels
{
    public class Quadrate : Shape, IQuadrate
    {
        public Quadrate(string name) : base(name)
        {
            Width = 100;
            Fill = Colors.Tomato;
        }
    }
}