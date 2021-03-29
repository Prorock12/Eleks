using Models.Interfaces.Models;
using Modules.Redactor.Interfaces;
using Prism.Mvvm;

namespace Modules.Redactor.ViewModels
{
    public abstract class ElementViewModel : BindableBase, IElementViewModel
    {
        #region Properties

        public IElement Element { get; set; }

        #endregion Properties

        #region Constructors

        protected ElementViewModel(IElement element)
        {
            Element = element;
        }

        protected ElementViewModel()
        {

        }
        #endregion Constructors
    }
}