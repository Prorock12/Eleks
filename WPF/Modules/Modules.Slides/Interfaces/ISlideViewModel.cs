﻿using Models.Interfaces.Models;

namespace Modules.Slides.Interfaces
{
    public interface ISlideViewModel
    {
        #region Properties

        ISlide Slide { get; set; }

        #endregion Properties
    }
}