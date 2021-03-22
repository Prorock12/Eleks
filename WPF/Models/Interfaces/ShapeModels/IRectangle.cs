using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Models.Interfaces.ShapeModels
{
    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
