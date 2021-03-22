using System.Windows.Controls;

namespace Services.DialogService.Service
{
    public class DialogService : IDialogService
    {
        #region Methods

        public object ShowDialog(UserControl userControl)
        {
            var window = new DialogWindow { WindowContent = userControl };
            window.ShowDialog();

            return window;
        }

        #endregion Methods
    }
}