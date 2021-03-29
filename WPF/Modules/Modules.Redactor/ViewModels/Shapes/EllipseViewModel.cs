using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class EllipseViewModel : ShapeViewModel,IEllipsViewModel
    {
        public IEllipse Ellipse { get; set; }
        public EllipseViewModel(IEllipse shape) : base(shape)
        {
            Ellipse = shape;
        }

        
    }
}