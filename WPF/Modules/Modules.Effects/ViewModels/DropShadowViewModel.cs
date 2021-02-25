using Models.Interfaces.Effects;
using System.Drawing;
using System.Linq;
using Infrastructure;


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

        public DropShadowViewModel(IDropShadowEffect dropShadowEffect) : base(dropShadowEffect,"DropShadow")
        {
            DropShadowEffect = dropShadowEffect;
            ExtendedDropShadowColor =
                ExtendedColorHelper.Colors.FirstOrDefault(c => c.Color.Equals(dropShadowEffect.Color));
        }
    }
}
