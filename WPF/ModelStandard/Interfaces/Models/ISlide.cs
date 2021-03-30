using System.Collections.ObjectModel;

namespace ModelStandard.Interfaces.Models
{
    public interface ISlide
    {
        #region Properties

        string Id { get; set; }
        string Name { get; set; }

        ObservableCollection<IElement> Elements { get; set; }

        #endregion Properties
    }
}