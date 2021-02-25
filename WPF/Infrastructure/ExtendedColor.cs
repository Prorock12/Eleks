using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Infrastructure
{
    public class ExtendedColor
    {
        public string Name { get; }
        public Color Color { get; }

        public ExtendedColor(string name,Color color)
        {
            Name = name;
            Color = color;
        }
    }
}
