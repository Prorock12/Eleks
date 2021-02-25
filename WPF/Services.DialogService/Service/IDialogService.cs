using System.Windows.Controls;

namespace Services.DialogService.Service
{
    public interface IDialogService
    {
        object ShowDialog(UserControl user);
    }
}