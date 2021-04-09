using Infrastructure;
using Prism.Regions;
using System;
using System.Linq;
using Unity;

namespace Services.NavigationServices
{
    public class NavigationService : INavigationService
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _unityContainer;

        public NavigationService(IRegionManager regionManager, IUnityContainer unityContainer)
        {
            _regionManager = regionManager;
            _unityContainer = unityContainer;
        }

        public void NavigateChatToAnotherView(Type type)
        {
            var region = _regionManager.Regions.FirstOrDefault(x => x.Name == RegionNames.Chat);

            if (region == null) return;

            region.RemoveAll();

            region.Add(_unityContainer.Resolve(type));
        }
    }
}