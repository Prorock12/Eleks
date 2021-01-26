using MyFirstProject.Interfaces.Models;
using MyFirstProject.Interfaces.ViewModels;
using MyFirstProject.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyFirstProject.ViewModels
{
    public class SlideViewModel : BindableBase, ISlideViewModel
    {
        #region Fields

        private IVisualElementViewModel _selectedElement;

        #endregion Fields

        #region Properties

        public ISlide Slide { get; set; }

        public ICommand AddTextElementCommand { get; }

        public ICommand AddImageElementCommand { get; }

        public ICommand AddVideoElementCommand { get; }

        public ICommand RemoveElementCommand { get; }

        public IVisualElementViewModel SelectedElement
        {
            get => _selectedElement;
            set => SetProperty(ref _selectedElement, value);
        }

        public bool IsSelected { get; set; }
        public ObservableCollection<IElementViewModel> Elements { get; set; }

        #endregion Properties

        #region Constructor

        public SlideViewModel(ISlide slide)
        {
            Slide = slide;

            AddTextElementCommand = new RelayCommand(AddText);
            AddImageElementCommand = new RelayCommand(AddImage);
            AddVideoElementCommand = new RelayCommand(AddVideo);
            RemoveElementCommand = new RelayCommand(RemoveElement);

            //Elements = new ObservableCollection<IElementViewModel>()
            //{
            //    new TextElementViewModel(new TextElement{Name = "Hello"}),
            //    new TextElementViewModel(new TextElement{Name = "World"}),
            //    new ImageElementViewModel(new ImageElement(){Name = "SomeImage"})
            //};
        }
        #endregion Constructor

        private void AddText(object obj)
        {
            var text = new TextElementViewModel(new TextElement { Name = "newText" });
            Elements.Insert(Elements.Count, text);
            SelectedElement = text;
        }

        private void AddImage(object obj)
        {
            var image = new ImageElementViewModel(new ImageElement { Name = "newImage" });
            Elements.Insert(Elements.Count, image);
            SelectedElement = image;
        }

        private void AddVideo(object obj)
        {
            var video = new VideoElementViewModel(new VideoElement { Name = "newVideo" });
            Elements.Insert(Elements.Count, video);
            SelectedElement = video;
        }
        private void RemoveElement(object obj)
        {
            Elements.Remove(SelectedElement);
        }

  
    }
}