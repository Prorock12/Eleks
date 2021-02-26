using Models.Interfaces.Models;
using Models.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;

namespace Modules.Accountant.ViewModels
{
    public class AccountantViewModel : BindableBase
    {
        private static Random _random = new Random();

        private IVisualElement _selectedElement;

        public ICommand AddRowCommand { get; set; }
        public ICommand RemoveRowCommand { get; set; }

        public IVisualElement SelectedElement
        {
            get => _selectedElement;
            set => SetProperty(ref _selectedElement, value);
        }

        public ObservableCollection<IVisualElement> Elements { get; set; }

        public AccountantViewModel()
        {
            AddRowCommand = new DelegateCommand(AddRow);
            RemoveRowCommand = new DelegateCommand(RemoveRow, () => SelectedElement != null).ObservesProperty(() => SelectedElement);

            Elements = new ObservableCollection<IVisualElement>();

            for (int i = 0; i < 1000; i++)
            {
                Elements.Add(CreateElement());
            }
        }

        private static IVisualElement CreateElement()
        {
            switch (_random.Next(1, 4))
            {
                case 1:
                    return new TextElement("New Text");

                case 2:
                    return new ImageElement("New Image");

                default:
                    return new VideoElement("New Video");
            }
        }

        private void AddRow()
        {
            Dispatcher.CurrentDispatcher.InvokeAsync(() =>
            {
                var newElement = CreateElement();
                Elements.Add(newElement);
                SelectedElement = newElement;
            }, DispatcherPriority.Loaded);
        }

        private void RemoveRow()
        {
            if (SelectedElement != null)
                Elements.Remove(SelectedElement);
        }
    }
}