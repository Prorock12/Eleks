using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Infrastructure.AttachedProperties
{
    public class ShaferAdorner : Adorner
    {
        #region fields

        protected readonly VisualCollection VisualChildren;

        #endregion fields

        #region properties

        protected override int VisualChildrenCount => VisualChildren.Count;

        #endregion properties

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