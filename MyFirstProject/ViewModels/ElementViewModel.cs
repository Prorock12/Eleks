using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using MyFirstProject.Interfaces.Models;
using MyFirstProject.Interfaces.ViewModels;

namespace MyFirstProject.ViewModels
{
    public abstract class ElementViewModel : BindableBase,IElementViewModel
    {
        #region Fields

        private bool _isSelected;
        private bool _isEnabled;

        #endregion

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
        public IElement Element { get; }

        #endregion

        #region Constructors

        protected ElementViewModel(IElement element)
        {
            Element = element;
        }

        #endregion
    }
}
