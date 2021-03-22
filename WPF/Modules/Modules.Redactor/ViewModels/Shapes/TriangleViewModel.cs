using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class TriangleViewModel : ShapeViewModel,ITriangleViewModel

    {
        private ITriangle _triangle;
        public ITriangle Triangle
        {
            get => _triangle;
            set => SetProperty(ref _triangle, value);
        }
        public TriangleViewModel(ITriangle shape) : base(shape)
        {
            Triangle = shape;
        }
    }
}
