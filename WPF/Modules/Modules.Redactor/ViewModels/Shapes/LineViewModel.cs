using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.ShapeModels;
using Modules.Redactor.Interfaces.InterfaceShapes;

namespace Modules.Redactor.ViewModels.Shapes
{
    public class LineViewModel : ShapeViewModel,ILineViewModel
    {
        private ILine _line;
        public ILine Line
        {
            get => _line;
            set => SetProperty(ref _line, value);
        }

        public LineViewModel(ILine shape) : base(shape)
        {
            Line = shape;
        }
    }
}
