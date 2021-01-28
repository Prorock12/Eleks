using Infrastructure;
using Modules.Redactor.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Redactor
{
    public class RedactorModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public RedactorModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.RedactorRegion, typeof(ElementContainerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}