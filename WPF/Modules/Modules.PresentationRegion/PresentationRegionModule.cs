using Infrastructure;
using Modules.PresentationRegion.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.PresentationRegion
{
    public class PresentationRegionModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public PresentationRegionModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.PresentationRegion, typeof(PresentationContainerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}