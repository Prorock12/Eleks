using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Infrastructure.AttachedProperties;

namespace CommonUI.ExtendedListBox
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
