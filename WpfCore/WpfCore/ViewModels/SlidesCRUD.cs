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
    public class SlidesCRUD : BindableBase
    {
        private Slide _selectedSlide;
        private IRepository<Slide> _db;
        public ICommand AddSlideCommand { get; }
        public ICommand UpdateSlideCommand { get; }
        public ICommand DeleteSlideCommand { get; }

        public Slide SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value);
        }

        public IRepository<Slide> Db
        {
            get => _db;
            set => SetProperty(ref _db, value);
        }

        public ObservableCollection<Slide> Slides { get; set; }
        public SlidesCRUD()
        {
            Slides = new ObservableCollection<Slide>();
            Db = new SlideRepository();
            foreach (var presentation in Db.GetElementsList())
            {
                Slides.Add(presentation);
            }

            AddSlideCommand = new DelegateCommand(AddSlide);
            UpdateSlideCommand = new DelegateCommand(UpdateSlide);
            DeleteSlideCommand = new DelegateCommand(DeleteSlide);

        }

        private void DeleteSlide()
        {
            if (SelectedSlide != null && Slides != null)
            {
                var index = Slides.Select(x => x.Id).FirstOrDefault(x => x == SelectedSlide.Id);
                if (index != null)
                {
                    Db.Delete(index);
                    Slides.Clear();
                    foreach (var item in Db.GetElementsList())
                    {
                        Slides.Add(item);
                    }
                }
            }
        }

        private void UpdateSlide()
        {
            Db.Update(SelectedSlide);
        }

        private void AddSlide()
        {
            var slide = new Slide("new Element"){Id = Guid.NewGuid().ToString()};
            Db.Create(slide);
            Slides.Clear();
            foreach (var item in Db.GetElementsList())
            {
                Slides.Add(item);
            }
        }
    }
}
