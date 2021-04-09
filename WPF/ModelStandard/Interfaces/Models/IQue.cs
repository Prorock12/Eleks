using System.Collections.ObjectModel;

namespace ModelStandard.Interfaces.Models
{
    public interface IQue
    {
        string Name { get; set; }

        ObservableCollection<ISlide> Slides { get; set; }
    }
}