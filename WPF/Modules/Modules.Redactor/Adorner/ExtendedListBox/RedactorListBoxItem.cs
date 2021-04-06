using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Modules.Redactor.Adorner.ExtendedListBox
{
    public class RedactorListBoxItem : ListBoxItem
    {
        private System.Windows.Documents.Adorner _adorner;

        protected override void OnSelected(RoutedEventArgs e)
        {
            base.OnSelected(e);
            //Background = Brushes.Transparent;
            if (VisualParent is Canvas)
            {
                //if (_adorner != null)
                //{
                //    var adornerLayer = AdornerLayer.GetAdornerLayer(this);
                //    adornerLayer?.Add(_adorner);
                //}
                //else
                //{
                    _adorner = new RedactorItemAdorner(this);
                    var adornerLayer = AdornerLayer.GetAdornerLayer(this);
                    adornerLayer?.Add(_adorner);
                //}
            }
        }

        protected override void OnUnselected(RoutedEventArgs e)
        {
            if (VisualParent is Canvas)
            {
                var adornerLayer = AdornerLayer.GetAdornerLayer(this);
                if (_adorner != null)
                    adornerLayer?.Remove(_adorner);
            }

            base.OnUnselected(e);
        }
    }
}