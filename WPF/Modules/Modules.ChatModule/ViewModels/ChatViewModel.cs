using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Models.Models.ChatModel;

namespace Modules.ChatModule.ViewModels
{
    public class ChatViewModel : BindableBase
    {
        private ObservableCollection<User> Users { get; }
        public ChatViewModel()
        {
            //Users = GetCountAsync().Result;
            GetUsersAsync();
        }

        public async Task GetUsersAsync()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5000/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var response =
                    await httpClient.GetAsync(@"api/users");

                if (response.IsSuccessStatusCode)
                { 
                    var users =  await response.Content.ReadAsAsync<IEnumerable<User>>();
                    foreach (var item in users)
                    {
                        Users.Add(item);
                    }
                }
            }
        }
    }
}