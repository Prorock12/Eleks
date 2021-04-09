using Models.Interfaces.Models;

namespace Modules.Que.Interfaces
{
    public interface IQueViewModel
    {
        #region Properties

        IQue Que { get; set; }

        ISlide SelectedSlide { get; set; }

        bool IsSelected { get; set; }

        #endregion Properties
    }
}