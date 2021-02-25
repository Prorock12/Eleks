using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Models.Models;
using Modules.Accountant.ViewModels;
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
            DependencyObject dep = (DependencyObject) e.OriginalSource;
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