using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.Models.ShapeModels
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
