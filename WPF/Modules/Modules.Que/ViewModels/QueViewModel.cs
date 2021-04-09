using Infrastructure.Events;
using Models.Interfaces.Models;
using Modules.Que.Interfaces;
using Prism.Events;
using Prism.Mvvm;

namespace Modules.Que.ViewModels
{
    public class QueViewModel : BindableBase, IQueViewModel
    {
        private ISlide _selectedSlide;
        private IEventAggregator _eventAggregator;
        private bool _isSelected;

        #region Properties

        public IQue Que { get; set; }

        public ISlide SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value, OnSelectedSlideChanged);
        }

        #endregion Properties

        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        #region Constructor

        public QueViewModel(IQue slide, IEventAggregator eventAggregator) : this(eventAggregator)
        {
            Que = slide;
        }

        public QueViewModel(IEventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        public QueViewModel()
        {
        }

        private void OnSelectedSlideChanged()
        {
            _eventAggregator.GetEvent<SelectedSlideEvent>().Publish(SelectedSlide);
        }

        #endregion Constructor
    }
}