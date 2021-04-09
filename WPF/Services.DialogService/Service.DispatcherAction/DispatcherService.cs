using Models.Interfaces.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace Service.DispatcherAction
{
    public class DispatcherService : IDispatcherService
    {
        public void Invoke(Action action)
        {
            Dispatcher.CurrentDispatcher.InvokeAsync(action, DispatcherPriority.Loaded);
        }
    }
}