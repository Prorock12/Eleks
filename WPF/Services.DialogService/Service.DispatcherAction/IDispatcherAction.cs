using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.Models;

namespace Service.DispatcherAction
{
    public interface IDispatcherAction
    {
        void AddRowDispatcher(ref ObservableCollection<IVisualElement> elements,Func<IVisualElement> createElement);
    }
}
