using Modules.Controller;
using Modules.PresentationRegion;
using Modules.Redactor;
using Modules.Slides;
using MyFirstProject.Views;
using Prism.Ioc;
using Prism.Modularity;
using Services.DialogService.Service;
using System.Windows;
using Modules.Accountant;
using Modules.Effects;
using Services.FilseSelector;

namespace MyFirstProject
{
    public partial class App
    {
        #region methods

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDialogService, DialogService>();
            containerRegistry.RegisterSingleton<IFileSelector, FileSelector>();
            //containerRegistry.RegisterDialog<ChangeSizeDialogView,ChangeSizeDialogViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<ShellView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<RedactorModule>();
            moduleCatalog.AddModule<PresentationRegionModule>();
            moduleCatalog.AddModule<SlidesModule>();
            moduleCatalog.AddModule<ControllerModule>();
            moduleCatalog.AddModule<EffectsModule>();
            moduleCatalog.AddModule<AccountantModule>();
        }

        #endregion
    }
}