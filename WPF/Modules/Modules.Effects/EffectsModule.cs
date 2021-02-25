using Infrastructure;
using Modules.Effects.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Effects
{
    public class EffectsModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public EffectsModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.EffectRegion, typeof(MainEffectView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}