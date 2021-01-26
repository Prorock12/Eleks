using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Modules.Redactor;
using MyFirstProject.Interfaces.ViewModels;
using MyFirstProject.ViewModels;
using MyFirstProject;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

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
        }
    }
}
