using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Models.Interfaces.ShapeModels
{
    public interface ILine : IShape
    {
        #region properties

        double X1 { get; set; }
        double X2 { get; set; }
        double Y1 { get; set; }
        double Y2 { get; set; }

        #endregion
    }
}
