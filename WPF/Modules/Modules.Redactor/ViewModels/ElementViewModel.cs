using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;
using Prism.Mvvm;

namespace Modules.Redactor.ViewModels
{
    public abstract class ElementViewModel : BindableBase, IElementViewModel
    {
        #region Fields

        private bool _isSelected;
        private bool _isEnabled;

        #endregion Fields

        #region Properties

        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        public IElement Element { get; set; }

        #endregion Properties

        #region Constructors

        protected ElementViewModel(IElement element)
        {
            Element = element;
        }

        #endregion Constructors
    }
}