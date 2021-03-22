using System.Windows;
using System.Windows.Controls;

namespace Modules.Redactor.Adorner.ExtendedListBox
{
    public class RedactorListBox : ListBox
    {
        public RedactorListBox()
        {
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new RedactorListBoxItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is RedactorListBoxItem;
        }
    }
}