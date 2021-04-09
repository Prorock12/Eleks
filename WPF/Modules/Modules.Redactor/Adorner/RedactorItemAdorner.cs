using Infrastructure.AttachedProperties;
using Modules.Redactor.Controls;
using Modules.Redactor.ViewModels.Shapes;
using System.Windows;
using System.Windows.Media;

namespace Modules.Redactor.Adorner
{
    public class RedactorItemAdorner : ShaferAdorner
    {
        private readonly RedactorItemThumb _redactorItemThumb;
        private readonly RedactorItemTriangleThumb _redactorItemTriangleThumb;
        private readonly FrameworkElement _element;
        private readonly VisualCollection _visualChildrens;

        public RedactorItemAdorner(FrameworkElement element) : base(element)
        {
            _element = element;
            _visualChildrens = new VisualCollection(this);
            if (element.DataContext is TriangleViewModel)
            {
                _redactorItemTriangleThumb = new RedactorItemTriangleThumb { DataContext = element.DataContext };

                _visualChildrens.Add(_redactorItemTriangleThumb);
            }
            else
            {
                _redactorItemThumb = new RedactorItemThumb { DataContext = element.DataContext };
                _redactorItemThumb.Background = Brushes.Transparent;

                _visualChildrens.Add(_redactorItemThumb);
            }
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            base.ArrangeOverride(finalSize);
            if (_element.DataContext is TriangleViewModel)
                _redactorItemTriangleThumb.Arrange(new Rect(finalSize));
            else
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