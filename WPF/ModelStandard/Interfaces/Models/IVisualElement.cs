using ModelStandard.Interfaces.Effects;

namespace ModelStandard.Interfaces.Models
{
    public interface IVisualElement : IElement, IBlurEffect, IPositionEffect, IBorderEffect, IDropShadowEffect, IMarginEffect
    {
    }
}