using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Documents;
using Infrastructure;
using MahApps.Metro.Controls;
using MyFirstProject.ViewModels;
using Services.ApplicationSettingsBase;

namespace MyFirstProject.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : MetroWindow
    {
        private ISettingsServices _settingsServices;
        public ShellView(ISettingsServices settingsServices)
        {
            _settingsServices = settingsServices;
            InitializeComponent();

            //var _adorner = AdornerLayer.GetAdornerLayer(TabItemController);
            //_adorner.Add(new SimpleCircleAdorner(TabItemController));
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(_settingsServices.CurrentLanguage);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_settingsServices.CurrentLanguage);
        }
    }
}