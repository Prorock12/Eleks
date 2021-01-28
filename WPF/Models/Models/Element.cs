using System.Collections.ObjectModel;
using Models.Interfaces.Models;
using Prism.Mvvm;

namespace Models.Models
{
    public abstract class Element : BindableBase, IElement
    {
        #region Fields

        private string _name;
        private string _id;

        #endregion Fields

        #region Properties

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public ObservableCollection<IElement> Elements { get; set; }
        #endregion Properties

        protected Element(string name)
        {
            Name = name;
        }
    }
}