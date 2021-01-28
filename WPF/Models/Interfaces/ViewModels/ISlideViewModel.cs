using Models.Interfaces.Models;

namespace Models.Interfaces.ViewModels
{
    public interface ISlideViewModel
    {
        #region Properties

        ISlide Slide { get; set; }
        //ObservableCollection<IElementViewModel> Elements { get;}

        #endregion Properties
    }
}