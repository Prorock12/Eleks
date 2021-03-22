using System.Windows;
using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.ShapeModels
{
    public class Triangle : Shape,ITriangle 
    {
        private Point _point1;
        private Point _point2;
        private Point _point3;
        private PointCollection _points;
        public Point Point1
        {
            get => _point1;
            set => SetProperty(ref _point1, value);
        }

        public Point Point2
        {
            get => _point2;
            set => SetProperty(ref _point2, value);
        }

        public Point Point3
        {
            get => _point3;
            set => SetProperty(ref _point3, value);
        }

        public PointCollection Points
        {
            get => _points;
            set => SetProperty(ref _points, value);
        }

        public Triangle(string name) : base(name)
        {
            Fill = new SolidColorBrush(Colors.FloralWhite);

            Points = new PointCollection();
            Point1 = new Point(10, 90);
            Point2 = new Point(50, 20);
            Point3 = new Point(90, 90);

            Points.Add(Point1);
            Points.Add(Point2);
            Points.Add(Point3);
        }
    }
}
