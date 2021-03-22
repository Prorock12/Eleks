using Infrastructure;
using Modules.Que.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Que
{
    public class QueModule : IModule
    {
        #region Fields

        private readonly IRegionManager _regionManager;

        #endregion Fields

        #region Constructor

        public QueModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion Constructor

        #region Methods

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.Que, typeof(QueContainerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        #endregion Methods
    }
}