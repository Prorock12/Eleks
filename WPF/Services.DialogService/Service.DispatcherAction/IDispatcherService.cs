using Models.Interfaces.Models;
using System;
using System.Collections.ObjectModel;

namespace Service.DispatcherAction
{
    public interface IDispatcherService
    {
        void Invoke(Action action);
    }
}