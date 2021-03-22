using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class RectangleViewModel : ShapeViewModel,IRectangleViewModel
    {
        private IRectangle _rectangle;
        public IRectangle Rectangle
        {
            get => _rectangle;
            set => SetProperty(ref _rectangle, value);
        }
        public RectangleViewModel(IRectangle shape) : base(shape)
        {
            Rectangle = shape;
        }

        
    }
}
