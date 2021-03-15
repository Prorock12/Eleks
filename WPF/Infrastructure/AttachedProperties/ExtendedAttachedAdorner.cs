using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Infrastructure.AttachedProperties
{
    public class ExtendedAttachedAdorner : FrameworkElement
    {
        public static readonly DependencyProperty AdornerProperty =
            DependencyProperty.RegisterAttached("Adorner", typeof(Type), typeof(ExtendedAttachedAdorner), new FrameworkPropertyMetadata(default(Type), PropertyChangedCallback));
        private static void PropertyChangedCallback(
            DependencyObject dependencyObject,
            DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            if (dependencyObject is FrameworkElement frameworkElement)
            {
                if (Activator.CreateInstance(
                    GetAdorner(frameworkElement),
                    frameworkElement) is Adorner adorner)
                {
                    var adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
                    adornerLayer?.Add(adorner);
                }
            }
        }

        //private static void Loaded(object sender, RoutedEventArgs e)
        //{
        //    if (sender is FrameworkElement frameworkElement)
        //    {
        //        if (Activator.CreateInstance(
        //            GetAdorner(frameworkElement),
        //            frameworkElement) is Adorner adorner)
        //        {
        //            var adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
        //            adornerLayer?.Add(adorner);
        //        }
        //    }
        //}
        public static void SetAdorner(DependencyObject element, Type value)
        {
            element.SetValue(AdornerProperty, value);
        }

        public static Type GetAdorner(DependencyObject element)
        {
            return (Type)element.GetValue(AdornerProperty);
        }
    }
}
