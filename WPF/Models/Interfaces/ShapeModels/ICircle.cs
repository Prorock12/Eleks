using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Models.Interfaces.ShapeModels
{
    public interface ICircle : IShape
    {
        #region properties

        double Diameter { get; set; }

        #endregion

    }
}
