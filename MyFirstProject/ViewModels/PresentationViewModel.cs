using MyFirstProject.Interfaces.Models;
using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyFirstProject.Interfaces.ViewModels;

namespace MyFirstProject.ViewModels
{
    public class PresentationViewModel : BindableBase, IPresentationViewModel
    {
        #region Fields

        private string _name;
        private string _path;
        private SlideViewModel _selectedSlide;

        #endregion

        #region Properties

        public ObservableCollection<ISlideViewModel> Slides { get; set; }
        public ICommand AddSlideCommand { get; }
        public ICommand RemoveSlideCommand { get; }
        public SlideViewModel SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value);
        }
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Path
        {
            get => _path;
            set => SetProperty(ref _path, value);
        }

        #endregion

        public PresentationViewModel(string presentation)
        {
            Name = presentation;
            AddSlideCommand = new RelayCommand(AddSlide);
            RemoveSlideCommand = new RelayCommand(RemoveSlide);

            Slides = new ObservableCollection<ISlideViewModel>
            {
                new SlideViewModel("FirstSlide"),
                new SlideViewModel("SecondSlide")
            };
        }

        #region Method

        private void AddSlide(object obj)
        {
            var slide = new SlideViewModel("nemSlide");
            Slides.Insert(Slides.Count, slide);
            SelectedSlide = slide;
        }
        private void RemoveSlide(object obj)
        {
            Slides.Remove(SelectedSlide);
        }

        #endregion

    }
}
