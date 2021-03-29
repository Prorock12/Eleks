using Infrastructure.EntityFramework;
using MahApps.Metro.Controls;
using Services.ApplicationSettingsBase;
using System;
using System.Globalization;
using System.Threading;

namespace MyFirstProject.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : MetroWindow
    {
        private ISettingsServices _settingsServices;
        private VisualElementContext db;

        public ShellView(ISettingsServices settingsServices)
        {
            //db = new VisualElementContext();
            //db.Elements.Load();
            //VisualElementGrid.ItemsSource = db.Elements.Local.ToBindingList();
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