using System.Windows.Media;
using Models.Interfaces.ShapeModels;
using Models.Models;

namespace Models.ShapeModels
{
    public abstract class Shape : VisualElement,IShape
    {
        private Brush _fill;

        public Brush Fill
        {
            get => _fill;
            set => SetProperty(ref _fill, value);
        }
        protected Shape(string name): base(name)
        {
            Name = name;
        }
    }
}
