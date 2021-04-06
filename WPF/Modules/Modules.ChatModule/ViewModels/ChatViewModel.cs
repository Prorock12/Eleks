using System.Collections.ObjectModel;
using PresentationWebApplication;
using PresentationWebApplication.Entities;
using PresentationWebApplication.Repositories;
using Prism.Mvvm;

namespace Modules.ChatModule.ViewModels
{
    public class ChatViewModel : BindableBase
    {
        public ObservableCollection<User> Users { get; set; }
        public ChatViewModel()
        {
            Users = new ObservableCollection<User>();
            LoadUsers();
        }

        public void LoadUsers()
        {

        }
    }
}
