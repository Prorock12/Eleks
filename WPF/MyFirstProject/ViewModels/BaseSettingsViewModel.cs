using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Services.DialogService.Service;

namespace MyFirstProject.ViewModels
{
    public class BaseSettingsViewModel : DialogViewModelBase<DialogResults>
    {
        private string _selectedItem;
        public string SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value, OnChangedLanguage);
        }

        public BaseSettingsViewModel()
        {

        }
        private void OnChangedLanguage()
        {
            var newCulture = new CultureInfo(SelectedItem);
            //var newCulture = Equals(CultureInfo.CurrentUICulture, new CultureInfo("en-US")) ? new CultureInfo("uk-UA") : new CultureInfo("en-US");
            App.ChangeCulture(newCulture);
            //System.Threading.Thread.CurrentThread.CurrentUICulture = IsChangeLanguage ? new System.Globalization.CultureInfo("uk-UA") : new System.Globalization.CultureInfo("en");
        }
    }
}
