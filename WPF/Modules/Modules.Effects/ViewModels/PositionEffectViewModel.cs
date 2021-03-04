using Models.Interfaces.Effects;
using Modules.Effects.Properties;

namespace Modules.Effects.ViewModels
{
    public class PositionEffectViewModel : EffectsViewModel
    {
        public IPositionEffect PositionEffect { get; }

        public PositionEffectViewModel(IPositionEffect positionEffect) : base(positionEffect, Resources.PositionEffect)
        {
            PositionEffect = positionEffect;
        }
    }
}