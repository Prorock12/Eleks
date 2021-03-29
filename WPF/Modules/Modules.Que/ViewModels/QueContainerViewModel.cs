using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Que.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace Modules.Que.ViewModels
{
    public class QueContainerViewModel : BindableBase
    {
        private IQueViewModel _selectedQue;
        private readonly IEventAggregator _eventAggregator;
        private IPresentation _selectedPresentation;

        public ICommand AddQueCommand { get; }
        public ICommand RemoveQueCommand { get; }
        public ICommand AddSlideCommand { get; }
        public ICommand RemoveSlideCommand { get; }
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
        public ObservableCollection<IQueViewModel> Ques { get; set; }

        public QueContainerViewModel(IEventAggregator eventAggregator)
        {
            Ques = new ObservableCollection<IQueViewModel>();
            _eventAggregator = eventAggregator;

            eventAggregator.GetEvent<SelectedPresentationEvent>().Subscribe(OnSelectedPresentation);
            eventAggregator.GetEvent<AddQueEvent>().Subscribe(OnAddQue);
            eventAggregator.GetEvent<RemoveQueEvent>().Subscribe(OnRemoveQue);

            AddQueCommand = new DelegateCommand(AddQue, CanChangeQue).ObservesProperty(() => SelectedPresentation);
            RemoveQueCommand =
                new DelegateCommand(RemoveQue, CanChangeQue).ObservesProperty(() => SelectedPresentation);

            AddSlideCommand = new DelegateCommand(AddSlide,CanChangeSlide).ObservesProperty(() => SelectedQue);
            RemoveSlideCommand = new DelegateCommand(RemoveSlide, CanChangeSlide).ObservesProperty(() => SelectedQue);
        }

        private bool CanChangeQue()
        {
            return SelectedPresentation != null;
        }
        private bool CanChangeSlide()
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

            if (SelectedPresentation.Ques?.Count > 0)
            {
                foreach (var que in SelectedPresentation.Ques)
                {
                    Ques.Add(new QueViewModel(que, _eventAggregator));
                }
            }
        }
        private void OnSelectedQueChanged()
        {
            _eventAggregator.GetEvent<SelectedQueEvent>().Publish(SelectedQue?.Que);
        }
        public void AddQue()
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
        private void AddSlide()
        {
            var newSlide = new Slide("newSlide");

            //_eventAggregator.GetEvent<AddSlideEvent>().Publish(newSlide);

            SelectedQue.Que.Slides.Add(newSlide);

            SelectedQue.SelectedSlide = newSlide;

        }
        private void RemoveSlide()
        {
            SelectedQue.Que.Slides.Remove(SelectedQue.SelectedSlide);

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
