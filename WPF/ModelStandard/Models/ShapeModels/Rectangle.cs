using System.Windows.Media;
using ModelStandard.Interfaces.ShapeModels;

namespace ModelStandard.Models.ShapeModels
{
    public class Rectangle : Shape,IRectangle
    {
        public Rectangle(string name) : base(name)
        {
            Width = 100;
            Height = 60;
            Fill = Colors.Gold;
        }
    }
}
