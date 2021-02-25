using Models.Interfaces.Effects;
using Models.Interfaces.Models;

namespace Modules.Effects.ViewModels
{
    public class BlurEffectViewModel : EffectsViewModel
    {
        public IBlurEffect BlurEffect { get; }

        public BlurEffectViewModel(IBlurEffect blurEffect) : base(blurEffect,"Blur")
        {
            BlurEffect = blurEffect;
        }
    }
}
