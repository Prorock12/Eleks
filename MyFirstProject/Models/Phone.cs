using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class Phone
    {
        Operation oper = new Operation();
        string title;
        string company;
        int price;

        public string Title
        {
            get { return title; }
            set
            {
                oper.SetProperty<string>(ref title, value);
            }
        }
        public string Company
        {
            get { return company; }
            set
            {
                oper.SetProperty<string>(ref company, value);
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                oper.SetProperty<int>(ref price, value);
            }
        }
    }
}
