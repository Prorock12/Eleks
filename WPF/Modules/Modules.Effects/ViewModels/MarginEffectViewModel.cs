using Models.Interfaces.Effects;
using Modules.Effects.Properties;
using System.Windows;

namespace Modules.Effects.ViewModels
{
    public class MarginEffectViewModel : EffectsViewModel
    {
        #region Fields

        private int _left;
        private int _right;
        private int _top;
        private int _bottom;

        #endregion Fields

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

        #endregion Properties

        public MarginEffectViewModel(IMarginEffect marginEffect) : base(marginEffect, Resources.MarginEffect)
        {
            MarginEffect = marginEffect;
        }

        private void OnMarginChanged()
        {
            MarginEffect.Margin = new Thickness(Left, Top, Right, Bottom);
        }
    }
}