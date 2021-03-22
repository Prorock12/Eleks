using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.ShapeModels
{
    public class Rectangle : Shape,IRectangle
    {
        public Rectangle(string name) : base(name)
        {
            Width = 100;
            Height = 60;
            Fill = new SolidColorBrush(Colors.Gold);
        }
    }
}
