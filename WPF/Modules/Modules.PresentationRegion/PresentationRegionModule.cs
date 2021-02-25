using Infrastructure;
using Modules.PresentationRegion.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.PresentationRegion
{
    public class PresentationRegionModule : IModule
    {
        #region Fields

        private readonly IRegionManager _regionManager;

        #endregion Fields

        #region Constructor

        public PresentationRegionModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion Constructor

        #region Methods

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.PresentationRegion, typeof(PresentationContainerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        #endregion Methods
    }
}