using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using Prism.Mvvm;
using WpfCore.EntityFramework;

namespace WpfCore.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private User _selectedElement;
        private ApplicationContext db = new ApplicationContext();
        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }

        public User SelectedElement
        {
            get =>_selectedElement;
            set => SetProperty(ref _selectedElement, value);
        }
        public MainWindowViewModel()
        {

            //CreateElemets();

            AddCommand = new DelegateCommand(Add);
            UpdateCommand = new DelegateCommand(Update);
            DeleteCommand = new DelegateCommand(Delete);

        }

        private void Delete()
        {
            var current = db.Users.FirstOrDefault( x => x == SelectedElement);
            if (current != null) db.Users.Remove(current);
            db.SaveChanges();
        }

        private void Update()
        {
            
            //throw new NotImplementedException();
        }

        private void Add()
        {
            User newUser = new User() {Name = "Bob", Age = 21};
            db.Users.Add(newUser);
            db.SaveChanges();
            db.Users.Load();
        }

        private void CreateElemets()
        {
            // создаем два объекта User
            User user1 = new User {Name = "Tom", Age = 33};
            User user2 = new User {Name = "Alice", Age = 26};


            // добавляем их в бд
            db.Users.Add(user1);
            db.Users.Add(user2);
            db.SaveChanges();
        }
    }
}
