using Infrastructure;
using Modules.Library.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Library
{
    public class LibraryModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public LibraryModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.Library, typeof(LibraryView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}