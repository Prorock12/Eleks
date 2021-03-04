using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Prism.Events;
using Services.FilseSelector;

namespace Modules.Library.ViewModels
{
    public class LibraryViewModel : BindableBase
    {
        private BitmapImage _bitmapImage;
        private string _selectedFolder;
        private readonly IFileSelector _fileSelector;
        public ICommand ChooseFolderCommand { get; }
        public ObservableCollection<LibraryItemViwModel> LibraryItems { get; set; }
        public LibraryItemViwModel LibraryItemViwModel { get; set; }

        //public BitmapImage BitmapImage
        //{
        //    get
        //    {
        //        if (_bitmapImage == null)
        //            Task.Run(LoadImages);
        //        else
        //        {
        //            return _bitmapImage;
        //        }
        //    };
        //    set=> SetProperty(ref _bitmapImage,value);
        //}

        public string SelectedFolder
        {
            get => _selectedFolder;
            set => SetProperty(ref _selectedFolder, value,OnChangedFolder);
        }

        private void OnChangedFolder()
        {
            //Task task = new Task(LoadImages);
            //task.Start();

            //Task.Factory.StartNew(LoadImages);
            LibraryItems.Clear();
            Task.Run(LoadImages);
        }

        public LibraryViewModel(IEventAggregator eventAggregator, IFileSelector fileSelector)
        {
            _fileSelector = fileSelector;

            LibraryItems = new ObservableCollection<LibraryItemViwModel>();
            ChooseFolderCommand = new DelegateCommand(ChooseFolder);
        }

        private void ChooseFolder()
        {
            //if ( != null) 
                SelectedFolder = _fileSelector.GetFolder().SelectedPath;
        }
        private void LoadImages()
        {
            //if (Images.Count != 0)
            foreach (var path in Directory.GetFiles(SelectedFolder))
            {
                if (path.EndsWith(".png") || path.EndsWith(".jpeg") || path.EndsWith(".jpg"))
                {
                    var item = new LibraryItemViwModel() {Path = path };
                    Application.Current.Dispatcher.InvokeAsync(()=>AddLibraryItem(item),DispatcherPriority.Background);
                }
            }
        }

        private void AddLibraryItem(LibraryItemViwModel item)
        {
            LibraryItems.Add(item);
        }
    }
}
