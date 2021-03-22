using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class QuadrateViewModel : ShapeViewModel,IQuadrateViewModel
    {
        private IQuadrate _quadrate;
        public IQuadrate Quadrate
        {
            get => _quadrate;
            set => SetProperty(ref _quadrate, value);
        }
        public QuadrateViewModel(IQuadrate shape) : base(shape)
        {
            Quadrate = shape;
        }

        
    }
}
