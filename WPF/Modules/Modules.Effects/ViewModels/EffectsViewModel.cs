using Infrastructure;
using Models.Interfaces.Effects;

namespace Modules.Effects.ViewModels
{
    public class EffectsViewModel : NotifyDataErrorViewModelBase
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public IEffect Effect { get; }

        public EffectsViewModel(IEffect effect, string name) : this()
        {
            Effect = effect;
            Name = name;
        }

        public EffectsViewModel()
        {
        }
    }
}