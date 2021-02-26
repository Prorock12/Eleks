using System;
using System.Windows;
using MyFirstProject.ViewModels;

namespace MyFirstProject.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShellViewModel.SetBaseSettings();
        }
    }
}