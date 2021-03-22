using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Models.Interfaces.Models;

namespace Models.Interfaces.ShapeModels
{
    public interface IShape : IVisualElement
    {
        #region properties

        Brush Fill { get; set; }

        #endregion
    }
}
