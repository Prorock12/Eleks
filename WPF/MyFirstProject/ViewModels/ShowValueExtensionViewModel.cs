using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Infrastructure;
using Microsoft.Xaml.Behaviors.Core;
using Services.DialogService.Service;

namespace MyFirstProject.ViewModels
{
    public class ShowValueExtensionViewModel : DialogViewModelBase<DialogResults>
    {
        private int _value;

        public int Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }

        public ICommand SolveCommand { get; }
        public ShowValueExtensionViewModel()
        {
            SolveCommand = new DelegateCommand(Solve);
        }

        private void Solve()
        {
            Value = Value.Clamp(10, 100);
        }
    }
}
