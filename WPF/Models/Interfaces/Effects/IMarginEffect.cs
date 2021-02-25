using System.Windows;

namespace Models.Interfaces.Effects
{
    public interface IMarginEffect : IEffect
    {
        Thickness Margin { get; set; }
    }
}
