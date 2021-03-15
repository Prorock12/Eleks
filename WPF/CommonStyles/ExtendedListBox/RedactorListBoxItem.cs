using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Infrastructure.AttachedProperties;

namespace CommonUI.ExtendedListBox
{
    public class RedactorListBoxItem : ListBoxItem
    {
        private Adorner _adorner;

        protected override void OnSelected(RoutedEventArgs e)
        {
            base.OnSelected(e);

           
            //Add adorner
            if (this is FrameworkElement frameworkElement)
            {
                _adorner = new BorderAdorner(this);
                var adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
                    adornerLayer?.Add(_adorner);
            }
        }

        protected override void OnUnselected(RoutedEventArgs e)
        {
            base.OnUnselected(e);
            if (this is FrameworkElement frameworkElement)
            {
                var adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
                    adornerLayer?.Remove(_adorner);
            }
        }
    }
}
