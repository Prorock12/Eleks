using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Modules.Redactor.Adorner.ExtendedListBox
{
    public class RedactorListBoxItem : ListBoxItem
    {
        private System.Windows.Documents.Adorner _adorner;

        protected override void OnSelected(RoutedEventArgs e)
        {
            base.OnSelected(e);

            if (this is FrameworkElement frameworkElement)
            {
                if (_adorner != null)
                {
                    var adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
                    adornerLayer?.Add(_adorner);
                }
                else
                {
                    _adorner = new RedactorItemAdorner(this);
                    var adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
                    adornerLayer?.Add(_adorner);
                }
            }
        }

        protected override void OnUnselected(RoutedEventArgs e)
        {
            if (this is FrameworkElement frameworkElement)
            {
                var adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
                adornerLayer?.Remove(_adorner);
            }
            base.OnUnselected(e);
        }
    }
}