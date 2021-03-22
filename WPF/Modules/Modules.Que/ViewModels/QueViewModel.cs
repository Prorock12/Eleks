using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Events;
using Models.Interfaces.Models;
using Modules.Que.Interfaces;
using Prism.Events;
using Prism.Mvvm;

namespace Modules.Que.ViewModels
{
    public class QueViewModel : BindableBase ,IQueViewModel
    {
        private ISlide _selectedSlide;
        private IEventAggregator _eventAggregator;
        #region Properties

        public IQue Que { get; set; }

        public ISlide SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value, OnSelectedSlideChanged);
        }
        #endregion Properties

        #region Constructor

        public QueViewModel(IQue slide ,IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Que = slide;
        }
        private void OnSelectedSlideChanged()
        {
            _eventAggregator.GetEvent<SelectedSlideEvent>().Publish(SelectedSlide); ;
        }
        #endregion Constructor
    }
}
