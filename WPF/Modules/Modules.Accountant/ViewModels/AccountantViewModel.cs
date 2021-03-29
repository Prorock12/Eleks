using Models.Interfaces.Models;
using Models.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;
using Service.DispatcherAction;

namespace Modules.Accountant.ViewModels
{
    public class AccountantViewModel : BindableBase
    {
        private static Random _random = new Random();

        private IVisualElement _selectedElement;
        private IDispatcherAction _dispatcherAction;

        public ICommand AddRowCommand { get; set; }
        public ICommand RemoveRowCommand { get; set; }

        public IVisualElement SelectedElement
        {
            get => _selectedElement;
            set => SetProperty(ref _selectedElement, value);
        }

        public ObservableCollection<IVisualElement> Elements { get; set; }

        public AccountantViewModel(IDispatcherAction dispatcherAction)
        {
            _dispatcherAction = dispatcherAction;
            AddRowCommand = new DelegateCommand(AddRow);
            RemoveRowCommand = new DelegateCommand(RemoveRow, () => SelectedElement != null).ObservesProperty(() => SelectedElement);

            Elements = new ObservableCollection<IVisualElement>();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Elements.Add(CreateElement());
            //}
        }
        //Should be private
        public IVisualElement CreateElement()
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
        //Should be private
        public void AddRow()
        {
            //Dispatcher.CurrentDispatcher.InvokeAsync(() =>
            //{
            //    var newElement = CreateElement();
            //    Elements?.Add(newElement);
            //    SelectedElement = newElement;
            //}, DispatcherPriority.Loaded);
            var observableCollection = Elements;
            _dispatcherAction.AddRowDispatcher(ref observableCollection,CreateElement);
        }
        //Should be private
        public void RemoveRow()
        {
            if (SelectedElement != null)
                Elements.Remove(SelectedElement);
        }
    }
}