using Models.Interfaces.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infrastructure.AttachedProperties
{
    public class BorderAdorner : ShaferAdorner
    {
        private readonly Thumb _topLeft;
        private readonly Thumb _topRight;
        private readonly Thumb _bottomLeft;
        private readonly Thumb _bottomRight;
        private readonly Thumb _top;
        private readonly Thumb _bottom;
        private readonly Thumb _left;
        private readonly Thumb _right;
        private readonly Thumb _rotateElement;
        private readonly Thumb _move;
        private readonly Rectangle _rectangle;

        private readonly FrameworkElement _element;

        private readonly VisualCollection _visualChildrens;

        private readonly IElement _visualElement;

        public BorderAdorner(UIElement element) : base(element)
        {
            _visualChildrens = new VisualCollection(this);
            _element = (FrameworkElement)element;

            //create ResizeT elemtn (resize thumb, borders...
            //set datacontext element.DataContext is VisualElemtnViewmodel
            //visualChilderans add ui element

            var item = _element.DataContext;
            BuildAdornerCorners(ref _topLeft, Cursors.SizeNWSE);
            BuildAdornerCorners(ref _topRight, Cursors.SizeNESW);
            BuildAdornerCorners(ref _bottomLeft, Cursors.SizeNESW);
            BuildAdornerCorners(ref _bottomRight, Cursors.SizeNWSE);

            BuildAdornerCorners(ref _rotateElement, Cursors.Hand);

            BuildAdornerCorners(ref _move, Cursors.SizeAll);

            BuildAdornerRectMove(ref _rectangle);

            BuildAdornerVector(ref _top, Cursors.SizeNS, 10, _element.Width);
            BuildAdornerVector(ref _bottom, Cursors.SizeNS, 10, _element.Width);
            BuildAdornerVector(ref _right, Cursors.SizeWE, _element.Height, 10);
            BuildAdornerVector(ref _left, Cursors.SizeWE, _element.Height, 10);

            //registering drag delta events for thumb drag movement
            _topLeft.DragDelta += TopLeft_DragDelta;
            _topRight.DragDelta += TopRight_DragDelta;
            _bottomLeft.DragDelta += BottomLeft_DragDelta;
            _bottomRight.DragDelta += BottomRight_DragDelta;

            _top.DragDelta += Top_DragDelta;
            _bottom.DragDelta += Bottom_DragDelta;
            _left.DragDelta += Left_DragDelta;
            _right.DragDelta += Right_DragDelta;

            _rotateElement.DragDelta += Rotate_DragDelta;

            _move.DragDelta += Move_DragDelta;
        }

        private void Move_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (AdornedElement is FrameworkElement adornedElement && sender is Thumb)
            {
                EnforceSize(adornedElement);

                Canvas.SetLeft(adornedElement, Canvas.GetLeft(adornedElement) + e.HorizontalChange);
                Canvas.SetTop(adornedElement, Canvas.GetTop(adornedElement) + e.VerticalChange);
            }
        }

        private void Rotate_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (AdornedElement is FrameworkElement adornedElement && sender is Thumb)
            {
                adornedElement.RenderTransformOrigin = new Point(50, 50);

                //var dragDelta = new Point(e.HorizontalChange, e.VerticalChange);

                if (adornedElement.RenderTransform is RotateTransform transform)
                {
                    //dragDelta = transform.Transform(dragDelta);
                    transform.Angle += 1;
                }

                //Canvas.SetLeft(adornedElement, Canvas.GetLeft(adornedElement) + dragDelta.X);
                //Canvas.SetTop(adornedElement, Canvas.GetTop(adornedElement) + dragDelta.Y);
            }
        }

        private void Bottom_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb bottomVector)
            {
                _left.Height = _element.Height;
                _right.Height = _element.Height;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldHeight = adornedElement.Height;

                var newHeight = Math.Max(oldHeight + e.VerticalChange, bottomVector.DesiredSize.Height);
                adornedElement.Height = newHeight;
            }
        }

        private void Right_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb rightVector)
            {
                _top.Width = _element.Width;
                _bottom.Width = _element.Width;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldWidth = adornedElement.Width;

                var newWidth = Math.Max(oldWidth + e.HorizontalChange, rightVector.DesiredSize.Width);
                adornedElement.Width = newWidth;
            }
        }

        private void Left_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb leftVector)
            {
                _top.Width = _element.Width;
                _bottom.Width = _element.Width;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldWidth = adornedElement.Width;

                var newWidth = Math.Max(oldWidth + e.HorizontalChange, leftVector.DesiredSize.Width);
                adornedElement.Width = newWidth;

                var oldLeft = Canvas.GetLeft(adornedElement);
                var newLeft = oldLeft - (newWidth - oldWidth);
                adornedElement.Width = newWidth;
                Canvas.SetLeft(adornedElement, newLeft);
            }
        }

        private void Top_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb topVector)
            {
                _left.Height = _element.Height;
                _right.Height = _element.Height;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldHeight = adornedElement.Height;

                var newHeight = Math.Max(oldHeight - e.VerticalChange, topVector.DesiredSize.Height);

                var oldTop = Canvas.GetTop(adornedElement);
                var newTop = oldTop - (newHeight - oldHeight);
                adornedElement.Height = newHeight;
                Canvas.SetTop(adornedElement, newTop);
            }
        }

        private void BottomRight_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb bottomRightCorner)
            {
                _top.Width = _element.Width;
                _bottom.Width = _element.Width;
                _left.Height = _element.Height;
                _right.Height = _element.Height;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldWidth = adornedElement.Width;
                var oldHeight = adornedElement.Height;

                var newWidth = Math.Max(oldWidth + e.HorizontalChange, bottomRightCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight + e.VerticalChange, bottomRightCorner.DesiredSize.Height);

                adornedElement.Width = newWidth;
                adornedElement.Height = newHeight;
            }
        }

        private void TopRight_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb topRightCorner)
            {
                _top.Width = _element.Width;
                _bottom.Width = _element.Width;
                _left.Height = _element.Height;
                _right.Height = _element.Height;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldWidth = adornedElement.Width;
                var oldHeight = adornedElement.Height;

                var newWidth = Math.Max(oldWidth + e.HorizontalChange, topRightCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight - e.VerticalChange, topRightCorner.DesiredSize.Height);
                adornedElement.Width = newWidth;

                var oldTop = Canvas.GetTop(adornedElement);
                var newTop = oldTop - (newHeight - oldHeight);
                adornedElement.Height = newHeight;
                Canvas.SetTop(adornedElement, newTop);
            }
        }

        private void TopLeft_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb topLeftCorner)
            {
                _top.Width = _element.Width;
                _bottom.Width = _element.Width;
                _left.Height = _element.Height;
                _right.Height = _element.Height;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldWidth = adornedElement.Width;
                var oldHeight = adornedElement.Height;

                var newWidth = Math.Max(oldWidth - e.HorizontalChange, topLeftCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight - e.VerticalChange, topLeftCorner.DesiredSize.Height);

                var oldLeft = Canvas.GetLeft(adornedElement);
                var newLeft = oldLeft - (newWidth - oldWidth);
                adornedElement.Width = newWidth;
                Canvas.SetLeft(adornedElement, newLeft);

                var oldTop = Canvas.GetTop(adornedElement);
                var newTop = oldTop - (newHeight - oldHeight);
                adornedElement.Height = newHeight;
                Canvas.SetTop(adornedElement, newTop);
            }
        }

        private void BottomLeft_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.AdornedElement is FrameworkElement adornedElement && sender is Thumb topRightCorner)
            {
                _top.Width = _element.Width;
                _bottom.Width = _element.Width;
                _left.Height = _element.Height;
                _right.Height = _element.Height;
                //_move.Height = _element.Height;
                //_move.Width = _element.Width;

                EnforceSize(adornedElement);

                var oldWidth = adornedElement.Width;
                var oldHeight = adornedElement.Height;

                var newWidth = Math.Max(oldWidth - e.HorizontalChange, topRightCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight + e.VerticalChange, topRightCorner.DesiredSize.Height);

                var oldLeft = Canvas.GetLeft(adornedElement);
                var newLeft = oldLeft - (newWidth - oldWidth);
                adornedElement.Width = newWidth;
                Canvas.SetLeft(adornedElement, newLeft);

                adornedElement.Height = newHeight;
            }
        }

        public void BuildAdornerCorners(ref Thumb cornerThumb, Cursor customizedCursors)
        {
            if (cornerThumb != null) return;
            cornerThumb = new Thumb() { Cursor = customizedCursors, Height = 10, Width = 10, Opacity = 0.5, Background = new SolidColorBrush(Colors.Blue) };
            _visualChildrens.Add(cornerThumb);
        }

        public void BuildAdornerVector(ref Thumb cornerThumb, Cursor customizedCursors, double height, double width)
        {
            if (cornerThumb != null) return;
            cornerThumb = new Thumb() { Cursor = customizedCursors, Height = height, Width = width, Opacity = 0.5, Background = new SolidColorBrush(Colors.Transparent) };
            _visualChildrens.Add(cornerThumb);
        }

        public void BuildAdornerRectMove(ref Rectangle cornerThumb)
        {
            if (cornerThumb != null) return;
            cornerThumb = new Rectangle() { Stroke = Brushes.Black, StrokeDashArray = { 4, 4 }, StrokeThickness = 2 };
            _visualChildrens.Add(cornerThumb);
        }

        public void EnforceSize(FrameworkElement element)
        {
            if (element.Width.Equals(Double.NaN))
                element.Width = element.DesiredSize.Width;
            if (element.Height.Equals(Double.NaN))
                element.Height = element.DesiredSize.Height;

            if (element.Parent is FrameworkElement parent)
            {
                element.MaxHeight = parent.ActualHeight;
                element.MaxWidth = parent.ActualWidth;
            }
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            base.ArrangeOverride(finalSize);

            var desireWidth = AdornedElement.DesiredSize.Width;
            var desireHeight = AdornedElement.DesiredSize.Height;

            var adornerWidth = this.DesiredSize.Width;
            var adornerHeight = this.DesiredSize.Height;

            var topPoint = new Point(0, -adornerHeight / 2);
            var bottomPoint = new Point(0, adornerHeight / 2);
            var topBottomVector = new Vector(adornerWidth, adornerHeight);

            var leftPoint = new Point(adornerWidth / 2, 0);
            var rightPoint = new Point(-adornerWidth / 2, 0);
            var leftRightVector = new Vector(adornerWidth, adornerHeight);

            var rotatePoint = new Point(0, -adornerHeight / 2 - 20);
            var rotateVector = new Vector(adornerWidth, adornerHeight);

            _topLeft.Arrange(new Rect(-adornerWidth / 2, -adornerHeight / 2, adornerWidth, adornerHeight));
            _topRight.Arrange(new Rect(desireWidth - adornerWidth / 2, -adornerHeight / 2, adornerWidth, adornerHeight));
            _bottomLeft.Arrange(new Rect(-adornerWidth / 2, desireHeight - adornerHeight / 2, adornerWidth, adornerHeight));
            _bottomRight.Arrange(new Rect(desireWidth - adornerWidth / 2, desireHeight - adornerHeight / 2, adornerWidth, adornerHeight));
            _top.Arrange(new Rect(topPoint, topBottomVector));
            _bottom.Arrange(new Rect(bottomPoint, topBottomVector));
            _left.Arrange(new Rect(leftPoint, leftRightVector));
            _right.Arrange(new Rect(rightPoint, leftRightVector));
            _rotateElement.Arrange(new Rect(rotatePoint, rotateVector));
            _move.Arrange(new Rect(adornerWidth / 2 + 20, 0, adornerWidth, adornerHeight));
            _rectangle.Arrange(new Rect(0, 0, adornerWidth, adornerHeight));
            return finalSize;
        }

        protected override int VisualChildrenCount { get { return _visualChildrens.Count; } }

        protected override Visual GetVisualChild(int index)
        {
            return _visualChildrens[index];
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
        }
    }
}