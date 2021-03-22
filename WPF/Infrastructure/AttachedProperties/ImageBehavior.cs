using Microsoft.Xaml.Behaviors;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;

namespace Infrastructure.AttachedProperties
{
    public class ImageBehavior : Behavior<Image>
    {
        protected override void OnAttached()
        {
            AssociatedObject.MouseDown += OnMouseDown;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.MouseDown -= OnMouseDown;
        }

        private void OnMouseDown(object sender, RoutedEventArgs e)
        {
            BitmapImage imageBitmap = new BitmapImage(new Uri("C:\\Users\\bohdan.hlyva\\Documents\\GitHub\\Eleks\\WPF\\Files\\Images\\Image1.jpg", UriKind.Absolute));
            var toolTip = new ToolTip
            {
                Content = new Image() { Source = imageBitmap },
                Width = 100,
                Height = 100,
                Placement = PlacementMode.Left
            };
            AssociatedObject.ToolTip = toolTip;
        }
    }
}