using System;

namespace Services.NavigationServices
{
    public interface INavigationService
    {
        void NavigateChatToAnotherView(Type type);
    }
}