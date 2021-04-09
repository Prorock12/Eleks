using ModelStandard.Interfaces.Models;
using System.Windows.Media;

namespace ModelStandard.Interfaces.ShapeModels
{
    public interface IShape : IVisualElement
    {
        #region properties

        Color Fill { get; set; }

        #endregion properties
    }
}