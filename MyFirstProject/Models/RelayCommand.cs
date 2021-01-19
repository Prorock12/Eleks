using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstProject.Models
{
    public class RelayCommand : ICommand
    {
        #region Field

        Action<object> execute;
        Func<object, bool> canExecute;

        #endregion

        #region Properties

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion

        #region Constructors

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion

        #region Methods

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        #endregion
    }
}
