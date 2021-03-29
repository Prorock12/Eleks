using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class LineViewModel : ShapeViewModel,ILineViewModel
    {
        public ILine Line { get; set; }

        public LineViewModel(ILine shape) : base(shape)
        {
            Line = shape;
        }
    }
}
