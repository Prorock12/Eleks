using System.Collections.ObjectModel;

namespace Models.Interfaces.Models
{
    public interface IQue
    {
        string Name { get; set; }

        ObservableCollection<ISlide> Slides { get; set; }
    }
}