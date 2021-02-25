using System.Windows;
using Models.Interfaces.Effects;

namespace Modules.Effects.ViewModels
{
    public class MarginEffectViewModel : EffectsViewModel
    {
        #region Fields

        private int _left;
        private int _right;
        private int _top;
        private int _bottom;

        #endregion

        #region Properties

        public int Left
        {
            get => _left;
            set => SetProperty(ref _left, value, OnMarginChanged);
        }

        public int Right
        {
            get => _right;
            set => SetProperty(ref _right, value, OnMarginChanged);
        }

        public int Top
        {
            get => _top;
            set => SetProperty(ref _top, value, OnMarginChanged);
        }

        public int Bottom
        {
            get => _bottom;
            set => SetProperty(ref _bottom, value, OnMarginChanged);
        }
        public IMarginEffect MarginEffect { get; }

        #endregion

        public MarginEffectViewModel(IMarginEffect marginEffect) : base (marginEffect,"Margin")
        {
            MarginEffect = marginEffect;
        }
        private void OnMarginChanged()
        {
            MarginEffect.Margin = new Thickness(Left, Top, Right, Bottom);
        }
    }
}
