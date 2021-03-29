﻿using System.Windows.Media;
using Models.Interfaces.ShapeModels;

namespace Models.Models.ShapeModels
{
    public class Quadrate : Shape,IQuadrate
    {

        public Quadrate(string name) : base(name)
        {
            Width = 100;
            Fill = Colors.Tomato;
        }

    }
}