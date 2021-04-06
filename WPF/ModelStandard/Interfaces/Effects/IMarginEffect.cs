using System.Windows;

namespace ModelStandard.Interfaces.Effects
{
    public interface IMarginEffect : IEffect
    {
        Thickness Margin { get; set; }
    }
}