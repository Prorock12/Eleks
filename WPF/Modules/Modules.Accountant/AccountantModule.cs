using Infrastructure;
using Modules.Accountant.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Accountant
{
    public class AccountantModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public AccountantModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.Accountant, typeof(AccountantView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}