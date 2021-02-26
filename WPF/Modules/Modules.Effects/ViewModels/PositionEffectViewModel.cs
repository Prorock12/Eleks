using Models.Interfaces.Effects;

namespace Modules.Effects.ViewModels
{
    public class PositionEffectViewModel : EffectsViewModel
    {
        public IPositionEffect PositionEffect { get; }

        public PositionEffectViewModel(IPositionEffect positionEffect) : base(positionEffect, "Position")
        {
            PositionEffect = positionEffect;
        }
    }
}