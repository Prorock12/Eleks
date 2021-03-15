using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Infrastructure.Events;
using Models.Models;
using Modules.Library.ViewModels;
using Prism.Events;

namespace Modules.Library.Views
{
    /// <summary>
    /// Interaction logic for LibraryView
    /// </summary>
    public partial class LibraryView : UserControl
    {
        readonly List<object> _selectedItems = new List<object>();
        public LibraryView()
        {
            InitializeComponent();
        }
        // Bad Idea add move event because it will called every time when you move your mouse
        //private void UIElement_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    ListBox parent = (ListBox)sender;
        //    object data = GetDataFromListBox(parent, e.GetPosition(parent));
        //    _selectedItems.Add(data);
        //    if (data != null)
        //    {
        //        DragDrop.DoDragDrop(parent, _selectedItems, DragDropEffects.Copy);
        //    }

        //}

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            _selectedItems.AddRange((IEnumerable<object>)e.AddedItems);
            if (e.RemovedItems.Count != 0)
            {
                var remove = _selectedItems.FirstOrDefault(x => x == e.RemovedItems[0]);
                _selectedItems.Remove(remove);
            }
            DragDrop.DoDragDrop(parent, _selectedItems, DragDropEffects.Copy);
        }

        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }
    }
}
