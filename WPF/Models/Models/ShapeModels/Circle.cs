using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.Models.ShapeModels
{
    public class Circle : Shape,ICircle
    {
        private double _diameter;

        public Circle(string name) : base(name)
        {
            Diameter = Width;
            Fill = Colors.Purple;
        }

        protected override void OnHeightChanged()
        {
            Diameter = Height;
        }

        protected override void OnWidthChanged()
        {
            Diameter = Width;
        }

        public double Diameter
        {
            get => _diameter;
            set => SetProperty(ref _diameter, value);
        }
    }
}
