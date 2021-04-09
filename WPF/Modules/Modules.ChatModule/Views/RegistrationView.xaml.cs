using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Modules.ChatModule.Views
{
    /// <summary>
    /// Interaction logic for Registration
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationCommands.GoToPage.Execute("/Views/Registration.xaml", this);
        }
    }
}