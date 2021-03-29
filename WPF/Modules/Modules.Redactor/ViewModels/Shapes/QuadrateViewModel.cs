using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class QuadrateViewModel : ShapeViewModel,IQuadrateViewModel
    {
        public IQuadrate Quadrate { get; set; }
        public QuadrateViewModel(IQuadrate shape) : base(shape)
        {
            Quadrate = shape;
        }

        
    }
}
