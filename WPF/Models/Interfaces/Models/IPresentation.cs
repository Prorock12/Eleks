using System.Collections.ObjectModel;

namespace Models.Interfaces.Models
{
    public interface IPresentation
    {
        #region Properties

        string Name { get; set; }
        string Path { get; set; }
        ObservableCollection<ISlide> Slides { get; set; }

        #endregion Properties
    }
}