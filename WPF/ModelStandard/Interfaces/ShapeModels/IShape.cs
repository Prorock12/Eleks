using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ModelStandard.Interfaces.Models;

namespace ModelStandard.Interfaces.ShapeModels
{
    public interface IShape : IVisualElement
    {
        #region properties

        Color Fill { get; set; }

        #endregion
    }
}
