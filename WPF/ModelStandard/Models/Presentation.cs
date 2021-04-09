using ModelStandard.Interfaces.Models;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace ModelStandard.Models
{
    public class Presentation : BindableBase, IPresentation
    {
        #region Fields

        private string _name;
        private string _path;
        private IResolution _resolution;
        private string _id;

        #endregion Fields

        #region Properties

        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
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

        public ObservableCollection<IQue> Ques { get; set; }

        public IResolution Resolution
        {
            get => _resolution;
            set => SetProperty(ref _resolution, value);
        }

        #endregion Properties

        #region Constructors

        public Presentation()
        {
            Resolution = new Resolution
            {
                Height = 1000,
                Width = 1000
            };

            Ques = new ObservableCollection<IQue>();
            //{
            //    new Que("First Que"),
            //    new Que("Second Que")
            //};

            Name = nameof(Presentation);
        }

        public Presentation(string name) : this()
        {
            Name = name;
        }

        #endregion Constructors
    }
}