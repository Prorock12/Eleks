using Models.Interfaces.Effects;

namespace Models.Interfaces.Models
{
    public interface IVisualElement : IElement, IBlurEffect, IPositionEffect,IBorderEffect,IDropShadowEffect,IMarginEffect
    {

    }
}