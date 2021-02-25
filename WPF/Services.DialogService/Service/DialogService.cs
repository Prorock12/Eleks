using System.Windows.Controls;

namespace Services.DialogService.Service
{
    public class DialogService : IDialogService
    {
        #region Methods

        public object ShowDialog(UserControl userControl)
        {
            DialogWindow window = new DialogWindow();
            window.WindowContent = userControl;
            window.ShowDialog();

            return window.DialogResult;
        }

        #endregion Methods
    }
}