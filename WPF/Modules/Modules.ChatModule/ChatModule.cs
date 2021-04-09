using Infrastructure;
using Modules.ChatModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.ChatModule
{
    public class ChatModule : IModule
    {
        #region Fields

        private readonly IRegionManager _regionManager;

        #endregion Fields

        #region Constructor

        public ChatModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion Constructor

        #region Methods

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.Chat, typeof(ChatView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        #endregion Methods
    }
}