using MyFirstProject.Interfaces.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public abstract class Element : BindableBase, IElement
    {
        #region Fields

        string _name;
        string _id;

        #endregion

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

        #endregion
    }
}
