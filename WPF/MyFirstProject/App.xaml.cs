﻿using Modules.Accountant;
using Modules.Controller;
using Modules.Effects;
using Modules.Library;
using Modules.PresentationRegion;
using Modules.Redactor;
using Modules.Slides;
using MyFirstProject.Views;
using Prism.Ioc;
using Prism.Modularity;
using Services.ApplicationSettingsBase;
using Services.DialogService.Service;
using Services.FilseSelector;
using System.Windows;
using Modules.Que;
using Service.DispatcherAction;

namespace MyFirstProject
{
    public partial class App
    {
        public App()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk-UA");
        }

        #region methods

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDialogService, DialogService>();
            containerRegistry.RegisterSingleton<IFileSelector, FileSelector>();
            containerRegistry.RegisterSingleton<ISettingsServices, SettingsServices>();
            containerRegistry.RegisterSingleton<IDispatcherAction, DispatcherAction>();
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
            moduleCatalog.AddModule<LibraryModule>();
            moduleCatalog.AddModule<QueModule>();
        }

        #endregion methods
    }
}