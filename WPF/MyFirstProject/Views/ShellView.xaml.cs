using System;
using System.Globalization;
using System.Threading;
using System.Windows;
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
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(_settingsServices.CurrentLanguage);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_settingsServices.CurrentLanguage);
        }
    }
}