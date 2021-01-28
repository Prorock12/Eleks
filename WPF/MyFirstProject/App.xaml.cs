using Modules.PresentationRegion;
using Modules.Redactor;
using Modules.Slides;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace MyFirstProject
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<ILocalization,Localization>;
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<RedactorModule>();
            moduleCatalog.AddModule<PresentationRegionModule>();
            moduleCatalog.AddModule<SlidesModule>();
        }
    }
}