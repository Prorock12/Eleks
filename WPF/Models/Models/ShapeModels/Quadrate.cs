using Models.Interfaces.ShapeModels;
using System.Windows.Media;

namespace Models.Models.ShapeModels
{
    public class Quadrate : Rectangle, IQuadrate
    {
        public Quadrate(string name) : base(name)
        {
            Width = 100;
            Fill = Colors.Tomato;
        }
    }
}