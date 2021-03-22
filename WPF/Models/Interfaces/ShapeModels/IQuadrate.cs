using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces.ShapeModels
{
    public interface IQuadrate : IShape
    {
        double Width { get; set; }
    }
}
