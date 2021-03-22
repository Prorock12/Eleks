using Infrastructure.AttachedProperties;
using Modules.Redactor.Controls;
using System.Windows;
using System.Windows.Media;

namespace Modules.Redactor.Adorner
{
    public class RedactorItemAdorner : ShaferAdorner
    {
        private readonly RedactorItemThumb _redactorItemThumb;
        private readonly VisualCollection _visualChildrens;

        public RedactorItemAdorner(FrameworkElement element) : base(element)
        {
            _visualChildrens = new VisualCollection(this);
            _redactorItemThumb = new RedactorItemThumb();
            _redactorItemThumb.DataContext = element.DataContext;

            _visualChildrens.Add(_redactorItemThumb);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            base.ArrangeOverride(finalSize);
            _redactorItemThumb.Arrange(new Rect(finalSize));
            return finalSize;
        }

        protected override int VisualChildrenCount { get { return _visualChildrens.Count; } }

        protected override Visual GetVisualChild(int index)
        {
            return _visualChildrens[index];
        }
    }
}