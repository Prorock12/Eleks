using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Regions;

namespace Services.NavigationServices
{
    public interface INavigationService
    {
        void NavigateChatToAnotherView(Type type);
    }
}
