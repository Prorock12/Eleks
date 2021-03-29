using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Models.Interfaces.Models;

namespace Service.DispatcherAction
{
    public class DispatcherAction : IDispatcherAction
    {
        public void AddRowDispatcher(ref ObservableCollection<IVisualElement> elements,Func<IVisualElement> createElement)
        {
            var collection = elements;
            Dispatcher.CurrentDispatcher.InvokeAsync(() =>
            {
                var newElement = createElement();
                collection?.Add(newElement);
            }, DispatcherPriority.Loaded);
        }
    }
}
