using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Xceed.Wpf.DataGrid;
using DataRow = Xceed.Wpf.DataGrid.DataRow;

namespace Modules.Accountant.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class AccountantView : UserControl
    {
        public AccountantView()
        {
            InitializeComponent();
        }

        private void RightButtonSelectElement_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            //TODO:Never do this
            DependencyObject dep = (DependencyObject)e.OriginalSource;
            while ((dep != null) && !(dep is DataCell))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null) return;

            if (dep is DataCell)
            {
                DataCell cell = dep as DataCell;
                cell.Focus();

                while ((dep != null) && !(dep is DataRow))
                {
                    dep = VisualTreeHelper.GetParent(dep);
                }

                DataRow row = dep as DataRow;
                ElementsGrid.SelectedItem = row.DataContext;
            }
        }

        private void ElementsGrid_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            e.NewFocus.Focus();
        }
    }
}