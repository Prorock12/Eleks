using ModelStandard.Interfaces.Models;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace ModelStandard.Models
{
    public class Que : BindableBase, IQue
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public ObservableCollection<ISlide> Slides { get; set; }

        public Que(string name) : this()
        {
            Name = name;
        }

        public Que()
        {
            Slides = new ObservableCollection<ISlide>();
            //{
            //    new Slide("First Slide"),
            //    new Slide("Second Slide")
            //};
        }
    }
}