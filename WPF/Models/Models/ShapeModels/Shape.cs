using Models.Interfaces.ShapeModels;
using System.Windows.Media;

namespace Models.Models.ShapeModels
{
    public abstract class Shape : VisualElement, IShape
    {
        private Color _fill;

        public Color Fill
        {
            get => _fill;
            set => SetProperty(ref _fill, value);
        }

        protected Shape(string name) : base(name)
        {
            Name = name;
        }
    }
}