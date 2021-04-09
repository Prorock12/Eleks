using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class CircleViewModel : ShapeViewModel, ICircleViewModel
    {
        public ICircle Circle { get; set; }

        public CircleViewModel(ICircle shape) : base(shape)
        {
            Circle = shape;
        }
    }
}