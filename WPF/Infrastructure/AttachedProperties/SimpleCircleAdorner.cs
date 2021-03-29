using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Infrastructure.AttachedProperties
{
    public class SimpleCircleAdorner : Adorner
    {
        public SimpleCircleAdorner(UIElement adornedElement) : base(adornedElement)
        {
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            string testString = "Hello World";

            // Create the initial formatted text string.
            FormattedText formattedText = new FormattedText(
                testString,
                CultureInfo.GetCultureInfo("en-us"),
                FlowDirection.LeftToRight,
                new Typeface("Verdana"),
                32,
                Brushes.Black);

            BitmapImage _imageBitmap = new BitmapImage(new Uri("C:\\Users\\bohdan.hlyva\\Documents\\GitHub\\Eleks\\WPF\\Files\\Images\\Image1.jpg", UriKind.Absolute));

            var adornedElementRect = new Rect(this.AdornedElement.DesiredSize);

            var renderBrush = new SolidColorBrush(Colors.Green) { Opacity = 0.2 };
            var renderPen = new Pen(new SolidColorBrush(Colors.Navy), 1.5);
            var renderRadius = 5.0;

            Image image = new Image()
            { Source = _imageBitmap };

            image.HorizontalAlignment = HorizontalAlignment.Right;
            image.VerticalAlignment = VerticalAlignment.Top;

            //ToolTip toolTip = new ToolTip() {Content = "Hello"};

            //drawingContext(toolTip,adornedElementRect);
            //drawingContext.DrawImage(image.Source,adornedElementRect);

            drawingContext.DrawText(formattedText, adornedElementRect.TopRight);

            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopLeft, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopRight, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomLeft, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
        }
    }
}