using System.Windows.Media;

namespace ModelStandard.Interfaces.Effects
{
    public interface IBorderEffect : IEffect
    {
        Color Background { get; set; }
        Color BorderBrush { get; set; }
        int BorderThickness { get; set; }
        int CornerRadius { get; set; }
        int Padding { get; set; }
    }
}