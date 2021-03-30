using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using ModelStandard.Interfaces.Models;
using ModelStandard.Models;
using Prism.Commands;
using Prism.Mvvm;
using WpfCore.EntityFramework;

namespace WpfCore.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IVisualElement _selectedElement;
        private ApplicationContext _db;
        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }

        public IVisualElement SelectedElement
        {
            get =>_selectedElement;
            set => SetProperty(ref _selectedElement, value);
        }

        public ApplicationContext Db 
        {
            get => _db;
            set => SetProperty(ref _db, value);
        }
        public MainWindowViewModel()
        {
            Db = new ApplicationContext();
            //CreateElemets();

            AddCommand = new DelegateCommand(Add);
            UpdateCommand = new DelegateCommand(Update);
            DeleteCommand = new DelegateCommand(Delete);

        }

        private void Delete()
        {
            //var current = _db.VisualElements.FirstOrDefault(x => x == SelectedElement);
            //if (current != null) _db.VisualElements.Remove(current);
            //_db.SaveChanges();
        }

        private void Update()
        {
            
            //throw new NotImplementedException();
        }

        private void Add()
        {
            //var image = new ImageElement("NewImage");
            //_db.VisualElements.Add(image);
            //_db.SaveChanges();
            //_db.VisualElements.Load();
        }

        private void CreateElemets()
        {
            // создаем два объекта User
            User user1 = new User {Name = "Tom", Age = 33};
            User user2 = new User {Name = "Alice", Age = 26};


            // добавляем их в бд
            _db.Users.Add(user1);
            _db.Users.Add(user2);
            _db.SaveChanges();
        }
    }
}
