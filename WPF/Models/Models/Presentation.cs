using Models.Interfaces.Models;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace Models.Models
{
    public class Presentation : BindableBase, IPresentation
    {
        #region Fields

        private string _name;
        private string _path;

        #endregion Fields

        #region Properties

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

        public ObservableCollection<ISlide> Slides { get; set; }

        #endregion Properties

        #region Constructor

        public Presentation()
        {
            Slides = new ObservableCollection<ISlide>()
            {
                new Slide("First Slide"),
                new Slide("Second")
            };
        }

        public Presentation(string name):this()
        {
            Name = name;
        }

        #endregion Constructor
    }
}