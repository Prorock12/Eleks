using Infrastructure.Events;
using Models.Models;
using Modules.Library.ViewModels;
using Prism.Events;
using System.Windows;
using System.Windows.Controls;

namespace Modules.Redactor.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ElementContainerView : UserControl
    {
        #region Fields

        private IEventAggregator _eventAggregator;

        #endregion Fields

        public ElementContainerView(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            InitializeComponent();
        }

        private void ListBoxItem_OnDrop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(typeof(LibraryItemViwModel));
            var newImageElement = new ImageElement("new Image") { Path = ((LibraryItemViwModel)data)?.Path };

            //< Setter Property = "attachedProperties:ExtendedAttachedAdorner.Adorner" Value = "{x:Type attachedProperties:BorderAdorner}" />

            _eventAggregator.GetEvent<AddImageElementEvent>().Publish(newImageElement);
            //parent.Items.Add(newImageElement);
        }
    }
}