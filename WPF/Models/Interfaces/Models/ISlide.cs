using System.Collections.ObjectModel;

namespace Models.Interfaces.Models
{
    public interface ISlide
    {
        #region Properties

        string Name { get; set; }

        ObservableCollection<IElement> Elements { get; set; }

        #endregion Properties
    }
}