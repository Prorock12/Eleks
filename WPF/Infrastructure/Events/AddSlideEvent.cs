﻿using Models.Interfaces.Models;
using Prism.Events;

namespace Infrastructure.Events
{
    public class AddSlideEvent : PubSubEvent<ISlide>
    {
    }
}