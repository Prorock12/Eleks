using MyFirstProject.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.ViewModels;

namespace MyFirstProject.Models
{
    public class Presentation : BindableBase, IPresentation
    {
        #region Fields

        private string _name;
        string _path;

        #endregion

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

        #endregion

        #region Constructor

        public Presentation()
        {

        }

        public Presentation(string name)
        {
            Name= name;
            Slides = new ObservableCollection<ISlide>();
        }

#endregion
    }
}
