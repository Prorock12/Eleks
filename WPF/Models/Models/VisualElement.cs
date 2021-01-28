using Models.Interfaces.Models;
using System;

namespace Models.Models
{
    public abstract class VisualElement : Element, IVisualElement
    {
        #region Fields

        private static Random _random = new Random();
        private int _randomValue = _random.Next(100, 400);

        private double _x;
        private double _y;
        private double _width;
        private double _height;
        private double _angle;

        #endregion Fields

        #region Properties

        public double X
        {
            get => _randomValue;
            set => SetProperty(ref _x, value);
        }

        public double Y
        {
            get => _randomValue;
            set => SetProperty(ref _y, value);
        }

        public double Width
        {
            get => _randomValue;

            set => SetProperty(ref _width, value);
        }

        public double Height
        {
            get => _randomValue;

            set => SetProperty(ref _height, value);
        }

        public double Angle
        {
            get => _randomValue;

            set => SetProperty(ref _angle, value);
        }

        #endregion Properties

        public VisualElement(string name) : base(name)
        {

        }
    }
}