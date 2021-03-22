using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class EllipseViewModel : ShapeViewModel,IEllipsViewModel
    {
        private IEllipse _ellipse;
        public IEllipse Ellipse
        {
            get => _ellipse;
            set => SetProperty(ref _ellipse, value);
        }
        public EllipseViewModel(IEllipse shape) : base(shape)
        {
            Ellipse = shape;
        }

        
    }
}
