using MyFirstProject.Interfaces.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class Slide : BindableBase,ISlide
    {
        #region Fields

        private string _name;

        #endregion

        #region Properties

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public ObservableCollection<IElement> Elements { get; }

        #endregion

        #region Constructors

        public Slide(string name)
        {
            Name = name;
            Elements = new ObservableCollection<IElement>();
        }
        public Slide()
        {

        }

        #endregion
    }
}
