using Models.Interfaces.ShapeModels;
using System.Windows.Media;

namespace Models.Models.ShapeModels
{
    public class Rectangle : Shape, IRectangle
    {
        public Rectangle(string name) : base(name)
        {
            Width = 100;
            Height = 60;
            Fill = Colors.Gold;
        }
    }
}