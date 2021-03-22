using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.ShapeModels
{
    public class Circle : Shape,ICircle
    {
        private double _diameter;

        public Circle(string name) : base(name)
        {
            Diameter = 120;
            Fill =new SolidColorBrush( Colors.Purple);
        }

        public double Diameter
        {
            get => _diameter;
            set => SetProperty(ref _diameter, value);
        }
    }
}
