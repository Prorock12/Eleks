using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;

namespace Modules.Redactor.Interfaces.InterfaceShapes
{
    public interface ITriangleViewModel
    {
        ITriangle Triangle { get; set; }
    }
}
