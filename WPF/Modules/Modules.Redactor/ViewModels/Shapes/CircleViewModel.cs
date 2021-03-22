using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class CircleViewModel :ShapeViewModel,ICircleViewModel
    {
        private ICircle _circle;
        public ICircle Circle
        {
            get => _circle;
            set => SetProperty(ref _circle, value);
        }

        public CircleViewModel(ICircle shape) : base(shape)
        {
            Circle = shape;
        }

       
    }
}
