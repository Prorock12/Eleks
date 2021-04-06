using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ModelStandard.Models;
using Prism.Commands;
using Prism.Mvvm;
using WpfCore.EntityFramework;
using WpfCore.EntityFramework.Repository;

namespace WpfCore.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private Presentation _selectedPresentation;
        private IRepository<Presentation> _db;
        public ICommand AddPresentationCommand { get; }
        public ICommand UpdatePresentationCommand { get; }
        public ICommand DeletePresentationCommand { get; }
        public VisualElementsCRUD VisualElementsCrud { get; set; }
        public SlidesCRUD SlidesCrud { get; set; }

        public Presentation SelectedPresentation
        {
            get => _selectedPresentation;
            set => SetProperty(ref _selectedPresentation, value);
        }

        public IRepository<Presentation> Db 
        {
            get => _db;
            set => SetProperty(ref _db, value);
        }

        public ObservableCollection<Presentation> Presentations { get; set; }
        public MainWindowViewModel()
        {
            Presentations = new ObservableCollection<Presentation>();
            VisualElementsCrud = new VisualElementsCRUD();
            SlidesCrud = new SlidesCRUD();
            Db = new PresentationRepository();
            foreach (var presentation in Db.GetElementsList())
            {
                Presentations.Add(presentation);
            }
            
            AddPresentationCommand = new DelegateCommand(AddPresentation);
            UpdatePresentationCommand = new DelegateCommand(UpdatePresentation);
            DeletePresentationCommand = new DelegateCommand(DeletePresentation);

        }

        private void DeletePresentation()
        {
            if (SelectedPresentation != null && Presentations != null)
            {
                var index = Presentations.Select(x=>x.Id).FirstOrDefault(x => x==SelectedPresentation.Id);
                if (index != null)
                {
                    Db.Delete(index);
                    Presentations.Clear();
                    foreach (var item in Db.GetElementsList())
                    {
                        Presentations.Add(item);
                    }
                }
            }
        }

        private void UpdatePresentation()
        {
            Db.Update(SelectedPresentation);
        }

        private void AddPresentation()
        {
            var presentation = new Presentation{Id = Guid.NewGuid().ToString(),Name = "new Presentation"};
            Db.Create(presentation);
            Presentations.Clear();
            foreach (var item in Db.GetElementsList())
            {
                Presentations.Add(item);
            }
        }
    }
}
