using Models.Interfaces.Models;
using System.Windows.Media;

namespace Models.Interfaces.ShapeModels
{
    public interface IShape : IVisualElement
    {
        #region properties

        Color Fill { get; set; }

        #endregion properties
    }
}