using MyFirstProject.Interfaces.Models;
using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyFirstProject.Interfaces.ViewModels;
using Prism.Commands;
using Prism.Regions;
using Share;

namespace MyFirstProject.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region Fields

        private PresentationViewModel _selectedPresentation;

        #endregion

        #region Properties
        public ObservableCollection<IPresentationViewModel> Presentations { get; set; }
        public ICommand AddPresentationCommand { get; }
        public ICommand RemovePresentationCommand { get; }

        public PresentationViewModel SelectedPresentation
        {
            get => _selectedPresentation;
            set => SetProperty(ref _selectedPresentation, value);
        }

        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
            AddPresentationCommand = new RelayCommand(AddPresentation);
            RemovePresentationCommand = new RelayCommand(RemovePresentation);

            Presentations = new ObservableCollection<IPresentationViewModel>
            {
                new PresentationViewModel(new Presentation{Name = "FirstPresentation" }),
                new PresentationViewModel(new Presentation{Name = "Second" })
            };

        }

        #endregion

        #region Methods

        private void AddPresentation(object obj)
        {
            var presentation = new PresentationViewModel(new Presentation { Name = "newSlide" });
            Presentations.Insert(Presentations.Count, presentation);
            SelectedPresentation = presentation;
        }
        private void RemovePresentation(object obj)
        {
            Presentations.Remove(SelectedPresentation);
        }

        private bool CanAddSlide(object obj)
        {
            if (Presentations.Count > 10)
                return false;
            else
                return true;
        }

        #endregion
    }
}
