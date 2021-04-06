using System.Collections.ObjectModel;

namespace ModelStandard.Interfaces.Models
{
    public interface IPresentation
    {
        #region Properties

        string Id { get; set; }
        string Name { get; set; }
        string Path { get; set; }
        IResolution Resolution { get; set; }
        ObservableCollection<IQue> Ques { get; set; }

        #endregion Properties
    }
}