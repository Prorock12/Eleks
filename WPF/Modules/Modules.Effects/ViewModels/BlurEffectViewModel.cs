using Models.Interfaces.Effects;

namespace Modules.Effects.ViewModels
{
    public class BlurEffectViewModel : EffectsViewModel
    {
        public IBlurEffect BlurEffect { get; }

        public BlurEffectViewModel(IBlurEffect blurEffect) : base(blurEffect, "Blur")
        {
            BlurEffect = blurEffect;
        }
    }
}