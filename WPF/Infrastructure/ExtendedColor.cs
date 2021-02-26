using System.Windows.Media;

namespace Infrastructure
{
    public class ExtendedColor
    {
        public string Name { get; }
        public Color Color { get; }

        public ExtendedColor(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }
}