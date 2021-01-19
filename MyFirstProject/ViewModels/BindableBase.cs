using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.ViewModels
{
    public class BindableBase : INotifyPropertyChanged
    {
        #region Properties

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        public void SetProperty<T>(ref T field, T value, [CallerMemberName] string prop = "")
        {
            field = value;
            OnPropertyChanged(prop);
        }

        #endregion
    }
}
