using System.Collections.ObjectModel;

namespace Models.Interfaces.Models
{
    public interface IPresentation
    {
        #region Properties

        string Name { get; set; }
        string Path { get; set; }
        IResolution Resolution { get; set; }
        ObservableCollection<IQue> Ques { get; set; }

        #endregion Properties
    }
}