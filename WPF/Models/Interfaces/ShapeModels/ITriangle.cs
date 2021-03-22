using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Models.Interfaces.ShapeModels
{
    public interface ITriangle : IShape
    {
        Point Point1 { get; set; }
        Point Point2 { get; set; }
        Point Point3 { get; set; }
        PointCollection Points { get; set; }
    }
}
