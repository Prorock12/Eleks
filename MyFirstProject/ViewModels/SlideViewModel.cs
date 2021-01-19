using MyFirstProject.Interfaces.ViewModels;
using MyFirstProject.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyFirstProject.ViewModels
{
    public class SlideViewModel : BindableBase, ISlideViewModel
    {
        #region Fields

        private IElementViewModel _element;
        private string _name;

        #endregion Fields

        #region Properties

        public ICommand AddTextElementCommand { get; }

        public ICommand AddImageElementCommand { get; }

        public ICommand AddVideoElementCommand { get; }

        public ICommand RemoveElementCommand { get; }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public IElementViewModel SelectedElement
        {
            get => _element;
            set => SetProperty(ref _element, value);
        }

        public bool IsSelected { get; set; }
        public ObservableCollection<IElementViewModel> Elements { get; set; }

        #endregion Properties

        #region Constructor

        public SlideViewModel(string name)
        {
            Name = name;

            AddTextElementCommand = new RelayCommand(AddText);
            AddImageElementCommand = new RelayCommand(AddImage);
            AddVideoElementCommand = new RelayCommand(AddVideo);
            RemoveElementCommand = new RelayCommand(RemoveElement);

            Elements = new ObservableCollection<IElementViewModel>()
            {
                new TextElementViewModel(new TextElement{Text = "Hello"}),
                new TextElementViewModel(new TextElement{Text = "World"}),
                new ImageElementViewModel(new ImageElement(){Name = "SomeImage"})
            };
        }
        #endregion Constructor

        private void AddText(object obj)
        {
            var text = new TextElementViewModel(new TextElement { Text = "newText" });
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