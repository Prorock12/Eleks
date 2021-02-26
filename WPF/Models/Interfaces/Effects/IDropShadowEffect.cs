using System.Windows.Media;

namespace Models.Interfaces.Effects
{
    public interface IDropShadowEffect : IEffect
    {
        Color Color { get; set; }
        int BlurRadius { get; set; }
        double Opacity { get; set; }
        int Direction { get; set; }
        int ShadowDepth { get; set; }
    }
}