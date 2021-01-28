using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;

namespace Modules.Redactor.ViewModels
{
    public abstract class VisualElementViewModel : ElementViewModel, IVisualElementViewModel
    {
        #region Properties

        public IVisualElement VisualElement { get; set; }

        #endregion Properties

        protected VisualElementViewModel(IVisualElement element) : base(element)
        {
            VisualElement = element;
        }
    }
}