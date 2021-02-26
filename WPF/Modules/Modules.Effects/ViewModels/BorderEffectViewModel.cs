using Infrastructure;
using Models.Interfaces.Effects;
using System.Linq;

namespace Modules.Effects.ViewModels
{
    public class BorderEffectViewModel : EffectsViewModel
    {
        private int _borderThickness;
        private int _cornerRadius;
        private int _padding;
        private ExtendedColor _extendedBackgroundColor;
        private ExtendedColor _extendedBorderBrushColor;

        public ExtendedColor ExtendedBackgroundColor
        {
            get => _extendedBackgroundColor;
            set => SetProperty(ref _extendedBackgroundColor, value, OnExtendedBackgroundColorChanged);
        }

        public ExtendedColor ExtendedBorderBrushColor
        {
            get => _extendedBorderBrushColor;
            set => SetProperty(ref _extendedBorderBrushColor, value, OnExtendedBorderBrushColorChanged);
        }

        private void OnExtendedBackgroundColorChanged()
        {
            if (ExtendedBackgroundColor == null)
            {
                return;
            }

            BorderEffect.Background = ExtendedBackgroundColor.Color;
        }

        private void OnExtendedBorderBrushColorChanged()
        {
            if (ExtendedBorderBrushColor == null)
            {
                return;
            }

            BorderEffect.BorderBrush = ExtendedBorderBrushColor.Color;
        }

        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                ValidateBorderThickness(value);
                RaisePropertyChanged();

                SetProperty(ref _borderThickness, value, OnBorderThicknessChanged);
            }
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                ValidateCornerRadius(value);
                RaisePropertyChanged();

                SetProperty(ref _cornerRadius, value, OnCornerRadiusChanged);
            }
        }

        public int Padding
        {
            get => _padding;
            set
            {
                ValidatePadding(value);
                RaisePropertyChanged();

                SetProperty(ref _padding, value, OnPaddingChanged);
            }
        }

        private void OnPaddingChanged()
        {
            BorderEffect.Padding = Padding;
        }

        private void OnCornerRadiusChanged()
        {
            BorderEffect.CornerRadius = CornerRadius;
        }

        private void OnBorderThicknessChanged()
        {
            BorderEffect.BorderThickness = BorderThickness;
        }

        public IBorderEffect BorderEffect { get; }

        public BorderEffectViewModel(IBorderEffect borderEffect) : base(borderEffect, "Border")
        {
            BorderEffect = borderEffect;
            BorderThickness = borderEffect.BorderThickness;
            CornerRadius = borderEffect.CornerRadius;
            Padding = borderEffect.Padding;
            ExtendedBackgroundColor =
                ExtendedColorHelper.Colors.FirstOrDefault(c => c.Color.Equals(borderEffect.Background));
            ExtendedBorderBrushColor =
                ExtendedColorHelper.Colors.FirstOrDefault(c => c.Color.Equals(borderEffect.BorderBrush));
        }
    }
}