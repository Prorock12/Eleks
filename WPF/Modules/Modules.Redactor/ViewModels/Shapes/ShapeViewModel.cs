using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;
using Prism.Mvvm;

namespace Modules.Redactor.ViewModels.Shapes
{
    public abstract class ShapeViewModel : VisualElementViewModel,IShapeViewModel
    {
        private IShape _shape;

        public IShape Shape
        {
            get => _shape;
            set => SetProperty(ref _shape, value);
        }
        protected ShapeViewModel(IShape shape) : base(shape)
        {
            Shape = shape;
        }
    }
}
