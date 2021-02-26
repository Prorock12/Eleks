using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace CommonUI
{
    public class ExtendedMediaElementControl : MediaElement
    {
        #region const

        private const string TotalTimeStringFormat = "{0} / {1}";
        private const string BaseTimerFormat = @"mm\:ss";

        #endregion const

        private readonly DispatcherTimer _positionTimer = new DispatcherTimer();

        #region dependency properties

        private static readonly DependencyProperty IsPlayingProperty =
            DependencyProperty.Register(nameof(IsPlaying), typeof(bool), typeof(ExtendedMediaElementControl), new PropertyMetadata(false, IsPlayingChanged));

        public static readonly DependencyProperty TotalTimerProperty =
            DependencyProperty.Register(nameof(TotalTimer), typeof(string), typeof(ExtendedMediaElementControl));

        public static readonly DependencyProperty ToggleButtonContentProperty =
            DependencyProperty.Register(nameof(ToggleButtonContent), typeof(string), typeof(ExtendedMediaElementControl));

        public static readonly DependencyProperty DurationVideoProperty =
            DependencyProperty.Register(nameof(DurationVideo), typeof(int), typeof(ExtendedMediaElementControl));

        public static readonly DependencyProperty SliderPositionValueProperty =
            DependencyProperty.Register(nameof(SliderPositionValue), typeof(int), typeof(ExtendedMediaElementControl));

        public static readonly DependencyProperty SliderVolumeValueProperty =
            DependencyProperty.Register(nameof(SliderVolumeValue), typeof(double), typeof(ExtendedMediaElementControl), new PropertyMetadata(0.0, SliderVolumeValueChanged));

        #endregion dependency properties

        #region Properties

        public bool IsPlaying
        {
            get => (bool)GetValue(IsPlayingProperty);
            set => SetValue(IsPlayingProperty, value);
        }

        public string TotalTimer
        {
            get => (string)GetValue(TotalTimerProperty);
            set => SetValue(TotalTimerProperty, value);
        }

        public string ToggleButtonContent
        {
            get => (string)GetValue(ToggleButtonContentProperty);
            set => SetValue(ToggleButtonContentProperty, value);
        }

        public int DurationVideo
        {
            get => (int)GetValue(DurationVideoProperty);
            set => SetValue(DurationVideoProperty, value);
        }

        public int SliderPositionValue
        {
            get => (int)GetValue(SliderPositionValueProperty);
            set => SetValue(SliderPositionValueProperty, value);
        }

        public double SliderVolumeValue
        {
            get => (double)GetValue(SliderVolumeValueProperty);
            set => SetValue(SliderVolumeValueProperty, value);
        }

        #endregion Properties

        #region constructor

        public ExtendedMediaElementControl()
        {
            LoadedBehavior = MediaState.Manual;
            UnloadedBehavior = MediaState.Manual;

            MediaOpened += OnMediaOpened;

            _positionTimer.Interval = TimeSpan.FromMilliseconds(1);
            _positionTimer.Tick += OnTimerTick;
            _positionTimer.Start();

            IsPlaying = true;
        }

        #endregion constructor

        #region Methods

        private void OnMediaOpened(object sender, RoutedEventArgs e)
        {
            SliderVolumeValue = Volume;
            DurationVideo = (int)NaturalDuration.TimeSpan.TotalMilliseconds;
            if (Source == null)
                TotalTimer = "No file selected...";
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (!NaturalDuration.HasTimeSpan) return;

            TotalTimer = string.Format(TotalTimeStringFormat, Position.ToString(BaseTimerFormat),
                NaturalDuration.TimeSpan.ToString(BaseTimerFormat));
            //TODO:add totaMiliseconds
            SliderPositionValue = (int)Position.TotalMilliseconds;
        }

        #region property changed callback

        private static void IsPlayingChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            //Check if value changed

            if (!(obj is ExtendedMediaElementControl localMediaControl)) return;

            localMediaControl.IsPlayingChanged((bool)e.NewValue);
        }

        private static void SliderVolumeValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (!(obj is ExtendedMediaElementControl localMediaControl)) return;

            localMediaControl.SliderVolumeValueChangedw((double)e.NewValue);
        }

        #endregion property changed callback

        #region property changed

        private void IsPlayingChanged(bool isPlaying)
        {
            if (isPlaying)
            {
                _positionTimer.Start();
                Play();
            }
            else
            {
                _positionTimer.Stop();
                Pause();
            }
        }

        private void SliderVolumeValueChangedw(double volume)
        {
            Volume = volume;
        }

        #endregion property changed

        #endregion Methods
    }
}