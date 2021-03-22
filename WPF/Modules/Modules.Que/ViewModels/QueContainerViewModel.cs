using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Que.Interfaces;
using Modules.Que.ViewModels;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace Modules.Que.ViewModels
{
    public class QueContainerViewModel : BindableBase
    {
        private ISlide _selectedSlide;
        private IQueViewModel _selectedQue;
        private readonly IEventAggregator _eventAggregator;
        private IPresentation _selectedPresentation;

        public ICommand AddQueCommand { get; }
        public ICommand RemoveQueCommand { get; }
        public ObservableCollection<ISlideViewModel> Slides { get; set; }
        public IPresentation SelectedPresentation
        {
            get => _selectedPresentation;
            set => SetProperty(ref _selectedPresentation, value, OnSelectedPresentationChanged);
        }
        public IQueViewModel SelectedQue
        {
            get => _selectedQue;
            set => SetProperty(ref _selectedQue, value, OnSelectedQueChanged);
        }
        public ISlide SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value, OnSelectedSlideChanged);
        }
        public ObservableCollection<IQueViewModel> Ques { get; }
        public QueContainerViewModel(IEventAggregator eventAggregator)
        {
            Ques = new ObservableCollection<IQueViewModel>();
            Slides = new ObservableCollection<ISlideViewModel>();
            _eventAggregator = eventAggregator;

            eventAggregator.GetEvent<SelectedPresentationEvent>().Subscribe(OnSelectedPresentation);
            eventAggregator.GetEvent<AddQueEvent>().Subscribe(OnAddQue);
            eventAggregator.GetEvent<RemoveQueEvent>().Subscribe(OnRemoveQue);

            AddQueCommand = new DelegateCommand(AddQue, CanChangeQue).ObservesProperty(() => SelectedQue);
            RemoveQueCommand = new DelegateCommand(RemoveQue, CanChangeQue).ObservesProperty(() => SelectedQue);
        }
        private bool CanChangeQue()
        {
            return SelectedQue != null;
        }
        private void OnSelectedPresentation(IPresentation presentation)
        {
            SelectedPresentation = presentation;
        }
        private void OnSelectedPresentationChanged()
        {
            Ques.Clear();
            OnLoadQues();
        }
        private void OnLoadQues()
        {
            if (SelectedPresentation == null)
            {
                return;
            }

            foreach (var que in SelectedPresentation.Ques)
            {
                Ques.Add(new QueViewModel(que,_eventAggregator));
            }
        }
        private void OnLoadSlides()
        {
            if (SelectedQue == null)
            {
                return;
            }

            foreach (var slide in SelectedQue.Que.Slides)
            {
                Slides.Add(new SlideViewModel(slide));
            }
        }
        private void OnSelectedQueChanged()
        {
            OnLoadSlides();
            //SelectedQue.Que.Slides = new ObservableCollection<ISlide>()
            //{

            //}
            _eventAggregator.GetEvent<SelectedQueEvent>().Publish(SelectedQue?.Que); ;
        }
        private void OnSelectedSlideChanged()
        {
            _eventAggregator.GetEvent<SelectedSlideEvent>().Publish(SelectedSlide); ;
        }
        private void AddQue()
        {
            var que = new Models.Models.Que("NewSlide");

            _eventAggregator.GetEvent<AddQueEvent>().Publish(que);

            SelectedPresentation.Ques.Add(que);
        }

        private void OnAddQue(IQue que)
        {
            var queViewModel = new QueViewModel(que,_eventAggregator);
            Ques.Add(queViewModel);
            SelectedQue = queViewModel;
        }

        private void RemoveQue()
        {
            SelectedPresentation.Ques.Remove(SelectedQue.Que);

            _eventAggregator.GetEvent<RemoveQueEvent>().Publish(SelectedQue.Que);
        }

        private void OnRemoveQue(IQue que)
        {
            var removeQue = Ques.First(x => x.Que == que);
            Ques.Remove(removeQue);
        }
    }
}
