using MyFirstProject.Interfaces.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public abstract class VisualElement : Element, IVisualElement
    {
        #region Fields

        static Random _random = new Random();
        private int _randomValue = _random.Next(100, 400);

        private double _x;
        private double _y;
        private double _width;
        private double _height;
        private double _angle;

        #endregion

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

        #endregion
    }
}