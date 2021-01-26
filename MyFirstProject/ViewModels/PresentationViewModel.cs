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

        private bool _isStackView;
        private SlideViewModel _selectedSlide;

        #endregion

        #region Properties

        public ObservableCollection<ISlideViewModel> Slides { get; set; }
        public ICommand AddSlideCommand { get; }
        public ICommand RemoveSlideCommand { get; }
        public IPresentation Presentation { get; set; }
        public bool IsStackView 
        {
            get => _isStackView;
            set => SetProperty(ref _isStackView,value); 
        }
        public SlideViewModel SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value);
        }

        #endregion

        public PresentationViewModel(IPresentation presentation)
        {
            Presentation = presentation;
            AddSlideCommand = new RelayCommand(AddSlide);
            RemoveSlideCommand = new RelayCommand(RemoveSlide);

            //Slides = new ObservableCollection<ISlideViewModel>
            //{
            //    new SlideViewModel(new Slide {Name="First" }),
            //    new SlideViewModel(new Slide {Name="SecondSlide" })
            //};
        }

        #region Method

        private void AddSlide(object obj)
        {
            var slide = new SlideViewModel(new Slide { Name = "nemSlide" });
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
