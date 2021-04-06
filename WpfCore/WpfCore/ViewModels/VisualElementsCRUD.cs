using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ModelStandard.Models;
using Prism.Commands;
using Prism.Mvvm;
using WpfCore.EntityFramework;
using WpfCore.EntityFramework.Repository;

namespace WpfCore.ViewModels
{
    public class VisualElementsCRUD : BindableBase
    {
        private VisualElement _selectedVisualElement;
        private IRepository<VisualElement> _db;
        public ICommand AddElementCommand { get; }
        public ICommand UpdateElementCommand { get; }
        public ICommand DeleteElementCommand { get; }

        public VisualElement SelectedVisualElement
        {
            get => _selectedVisualElement;
            set => SetProperty(ref _selectedVisualElement, value);
        }

        public IRepository<VisualElement> Db
        {
            get => _db;
            set => SetProperty(ref _db, value);
        }

        public ObservableCollection<VisualElement> VisualElements { get; set; }
        public VisualElementsCRUD()
        {
            VisualElements = new ObservableCollection<VisualElement>();
            Db = new ElementRepository();
            foreach (var presentation in Db.GetElementsList())
            {
                VisualElements.Add(presentation);
            }

            AddElementCommand = new DelegateCommand(AddElement);
            UpdateElementCommand = new DelegateCommand(UpdateElement);
            DeleteElementCommand = new DelegateCommand(DeleteElement);

        }

        private void DeleteElement()
        {
            if (SelectedVisualElement != null && VisualElements != null)
            {
                var index = VisualElements.Select(x => x.Id).FirstOrDefault(x => x == SelectedVisualElement.Id);
                if (index != null)
                {
                    Db.Delete(index);
                    VisualElements.Clear();
                    foreach (var item in Db.GetElementsList())
                    {
                        VisualElements.Add(item);
                    }
                }
            }
        }

        private void UpdateElement()
        {
            Db.Update(SelectedVisualElement);
        }

        private void AddElement()
        {
            var presentation = new VisualElement("new Element");
            Db.Create(presentation);
            VisualElements.Clear();
            foreach (var item in Db.GetElementsList())
            {
                VisualElements.Add(item);
            }
        }
    }
}
