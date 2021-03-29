using Infrastructure;
using Models.Interfaces.Effects;
using Modules.Effects.Properties;
using System.Linq;

namespace Modules.Effects.ViewModels
{
    public class DropShadowViewModel : EffectsViewModel
    {
        private ExtendedColor _extendedDropShadowColor;

        public ExtendedColor ExtendedDropShadowColor
        {
            get => _extendedDropShadowColor;
            set => SetProperty(ref _extendedDropShadowColor, value, OnExtendedBackgroundColorChanged);
        }

        private void OnExtendedBackgroundColorChanged()
        {
            if (ExtendedDropShadowColor == null)
            {
                return;
            }

            DropShadowEffect.Color = ExtendedDropShadowColor.Color;
        }

        public IDropShadowEffect DropShadowEffect { get; }

        public DropShadowViewModel(IDropShadowEffect dropShadowEffect) : base(dropShadowEffect, Resources.DropShadow)
        {
            DropShadowEffect = dropShadowEffect;
            ExtendedDropShadowColor =
                ExtendedColorHelper.Colors.FirstOrDefault(c => c.Color.Equals(dropShadowEffect.Color));
        }
    }
}