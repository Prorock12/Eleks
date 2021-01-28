using MyFirstProject.ViewModels;
using Prism.Regions;
using System.Windows;

namespace MyFirstProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }
    }
}