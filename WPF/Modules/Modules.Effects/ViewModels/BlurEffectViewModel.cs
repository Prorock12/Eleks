using Models.Interfaces.Effects;
using Modules.Effects.Properties;

namespace Modules.Effects.ViewModels
{
    public class BlurEffectViewModel : EffectsViewModel
    {
        public IBlurEffect BlurEffect { get; }

        public BlurEffectViewModel(IBlurEffect blurEffect) : base(blurEffect, Resources.Blur)
        {
            BlurEffect = blurEffect;
        }
    }
}