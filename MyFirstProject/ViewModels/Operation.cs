using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.ViewModels
{
    public class Operation
    {
        public void SetProperty<T>(ref T properties, T value)
        {
            BaseViewModel baseViewModel = new BaseViewModel();
            properties = value;
            baseViewModel.OnPropertyChanged(properties.ToString());
            
        }
    }
}
