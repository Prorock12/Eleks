using System;
using System.Windows;
using System.Windows.Controls;

namespace Modules.Redactor.Styles
{
    public partial class VideoPlayer : UserControl
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void PositionSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (((Slider)sender).IsMouseCaptureWithin)
                MediaPlayer.Position = TimeSpan.FromMilliseconds(e.NewValue);
        }
    }
}