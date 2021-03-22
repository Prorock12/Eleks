using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.Models;
using Prism.Mvvm;

namespace Models.Models
{
    public class Que : BindableBase,IQue
    {
        private string _name;
        private ObservableCollection<ISlide> _slides;

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
            Slides = new ObservableCollection<ISlide>()
            {
                new Slide("First Slide"),
                new Slide("Second Slide")
            };
        }
    }
}
