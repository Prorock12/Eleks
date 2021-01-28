using Infrastructure;
using Modules.Slides.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Slides
{
    public class SlidesModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public SlidesModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.SlideRegion, typeof(SlideContainerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}