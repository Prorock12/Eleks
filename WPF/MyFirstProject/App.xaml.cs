using System.Globalization;
using System.Threading;
using Modules.Accountant;
using Modules.Controller;
using Modules.Effects;
using Modules.PresentationRegion;
using Modules.Redactor;
using Modules.Slides;
using MyFirstProject.Views;
using Prism.Ioc;
using Prism.Modularity;
using Services.DialogService.Service;
using Services.FilseSelector;
using System.Windows;

namespace MyFirstProject
{
    public partial class App
    {
        public App()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk-UA");
        }

        #region methods

        public static void ChangeCulture(CultureInfo newCulture)
        {
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            var oldWindow = Application.Current.MainWindow;

            Application.Current.MainWindow = new ShellView();
            Application.Current.MainWindow.Show();

            oldWindow?.Close();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDialogService, DialogService>();
            containerRegistry.RegisterSingleton<IFileSelector, FileSelector>();
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

        #endregion methods
    }
}