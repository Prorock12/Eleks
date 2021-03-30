using System.Windows.Media.Effects;

namespace ModelStandard.Interfaces.Effects
{
    public interface IBlurEffect : IEffect
    {
        int Radius { get; set; }
        KernelType KernelType { get; set; }
        RenderingBias RenderingBias { get; set; }
    }
}