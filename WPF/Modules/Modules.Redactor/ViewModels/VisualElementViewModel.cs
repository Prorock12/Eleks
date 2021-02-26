using Models.Interfaces.Models;
using Modules.Redactor.Interfaces;

namespace Modules.Redactor.ViewModels
{
    public abstract class VisualElementViewModel : ElementViewModel, IVisualElementViewModel
    {
        public IVisualElement VisualElement { get; set; }

        #region Constructors

        protected VisualElementViewModel(IVisualElement element) : base(element)
        {
            VisualElement = element;
        }

        #endregion Constructors
    }
}