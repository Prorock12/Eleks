using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Infrastructure.AttachedProperties
{
    public class ShaferAdorner : Adorner
    {
        #region fields

        protected readonly VisualCollection VisualChildren;

        #endregion

        #region properties

        protected override int VisualChildrenCount => VisualChildren.Count;

        #endregion

        public ShaferAdorner(UIElement adornerElement) : base(adornerElement)
        {
            VisualChildren = new VisualCollection(this);
        }

        protected override Visual GetVisualChild(int index)
        {
            return VisualChildren[index];
        }
    }
}
