using System.Windows;
using System.Windows.Controls;

namespace Services.DialogService.Service
{
    public partial class DialogWindow : IDialogWindow
    {
        #region dependecy properties

        private static DependencyProperty WindowContentProperty;

        #endregion dependecy properties

        #region property

        public UserControl WindowContent
        {
            get { return (UserControl)GetValue(WindowContentProperty); }
            set { SetValue(WindowContentProperty, value); }
        }

        #endregion property

        static DialogWindow()
        {
            WindowContentProperty = DependencyProperty.Register(nameof(WindowContent), typeof(UserControl), typeof(DialogWindow));
        }

        public DialogWindow()
        {
            InitializeComponent();
        }

        private void Save()
        {
            //Close
        }

        //Cancel
    }
}