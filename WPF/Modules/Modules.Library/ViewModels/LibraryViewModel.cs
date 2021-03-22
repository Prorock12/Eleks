using Prism.Commands;
using Prism.Mvvm;
using Services.ApplicationSettingsBase;
using Services.FilseSelector;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Modules.Library.ViewModels
{
    public class LibraryViewModel : BindableBase
    {
        #region Fields

        private string _selectedFolder;
        private readonly IFileSelector _fileSelector;
        private readonly ISettingsServices _settingsServices;

        #endregion Fields

        #region Properties

        public ICommand ChooseFolderCommand { get; }
        public ObservableCollection<LibraryItemViwModel> LibraryItems { get; set; }

        public string SelectedFolder
        {
            get => _selectedFolder;
            set => SetProperty(ref _selectedFolder, value, OnChangedFolder);
        }

        #endregion Properties

        #region Methods

        private void OnChangedFolder()
        {
            LibraryItems.Clear();
            //Task task = new Task(LoadImages);
            //task.Start();

            Parallel.Invoke(LoadImages);

            //Thread thread = new Thread(LoadImages);
            //thread.Priority = ThreadPriority.AboveNormal;
            //thread.Start();

            //Task.Factory.StartNew(LoadImages);

            //Task.Run(LoadImages);
        }

        public LibraryViewModel(IFileSelector fileSelector, ISettingsServices settingsServices)
        {
            _settingsServices = settingsServices;
            _fileSelector = fileSelector;

            LibraryItems = new ObservableCollection<LibraryItemViwModel>();
            ChooseFolderCommand = new DelegateCommand(ChooseFolder);

            if (_settingsServices.CurrentFolderPath != null)
            {
                SelectedFolder = _settingsServices.CurrentFolderPath;
            }
        }

        private void ChooseFolder()
        {
            var folderPAth = _fileSelector.GetFolder();
            if (folderPAth != null)
            {
                _settingsServices.CurrentFolderPath = folderPAth.SelectedPath;
                SelectedFolder = _settingsServices.CurrentFolderPath;
            }
        }

        private void LoadImages()
        {
            foreach (var path in Directory.GetFiles(SelectedFolder))
            {
                if (path.EndsWith(".png") || path.EndsWith(".jpeg") || path.EndsWith(".jpg"))
                {
                    var item = new LibraryItemViwModel() { Path = path };
                    Application.Current.Dispatcher.InvokeAsync(() => AddLibraryItem(item), DispatcherPriority.Background);
                }
            }
        }

        private void AddLibraryItem(LibraryItemViwModel item)
        {
            LibraryItems.Add(item);
        }

        #endregion Methods
    }
}