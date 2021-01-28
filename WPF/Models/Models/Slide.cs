using Models.Interfaces.Models;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace Models.Models
{
    public class Slide : BindableBase, ISlide
    {
        #region Fields

        private string _name;

        #endregion Fields

        #region Properties

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public ObservableCollection<IElement> Elements { get; }

        #endregion Properties

        #region Constructors

        public Slide(string name) :this()
        {
            Name = name;
        }

        public Slide()
        {
            Elements = new ObservableCollection<IElement>()
            {
                new TextElement("Hello"),
                new ImageElement("World"),
                new VideoElement("SomeImage")
            };

            Name = nameof(Slide);
        }

        #endregion Constructors
    }
}