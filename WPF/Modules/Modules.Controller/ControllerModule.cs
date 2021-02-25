using Infrastructure;
using Modules.Controller.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Controller
{
    public class ControllerModule : IModule
    {
        #region Fields

        private readonly IRegionManager _regionManager;

        #endregion Fields

        #region Constructor

        public ControllerModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion Constructor

        #region Methods

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ControllerRegion, typeof(ControllerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        #endregion Methods
    }
}