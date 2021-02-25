using Prism.Mvvm;

namespace Services.DialogService.Service
{
    public abstract class DialogViewModelBase<T> : BindableBase
    {
        #region Properties

        public string Title { get; set; }
        public string Message { get; set; }
        public T DialogResult { get; set; }

        #endregion Properties

        #region Constructors

        protected DialogViewModelBase() : this(string.Empty, string.Empty)
        {
        }

        protected DialogViewModelBase(string title) : this(title, string.Empty)
        {
        }

        protected DialogViewModelBase(string title, string message)
        {
            Title = title;
            Message = message;
        }

        #endregion Constructors

        #region Methods

        public void CloseDialogWithResult(IDialogWindow dialog, T result)
        {
            DialogResult = result;

            if (dialog != null)
            {
                dialog.DialogResult = true;
            }
        }

        #endregion Methods
    }
}