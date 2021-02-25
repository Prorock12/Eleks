using Infrastructure;
using Modules.Redactor.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Redactor
{
    public class RedactorModule : IModule
    {
        #region Fields

        private readonly IRegionManager _regionManager;

        #endregion Fields

        #region Constructor

        public RedactorModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion Constructor

        #region Methods

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.RedactorRegion, typeof(ElementContainerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        #endregion Methods
    }
}