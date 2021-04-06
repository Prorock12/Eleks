using Infrastructure.Events;
using Models.Interfaces.Effects;
using Models.Interfaces.Models;
using Prism.Events;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Modules.Effects.ViewModels
{
    public class MainEffectViewModel
    {
        public ObservableCollection<EffectsViewModel> Effects { get; }

        public IVisualElement SelectedElement { get; set; }

        public MainEffectViewModel(IEventAggregator eventAggregator)
        {
            Effects = new ObservableCollection<EffectsViewModel>();

            eventAggregator.GetEvent<SelectedElementEvent>().Subscribe(Load);
        }

        private void Load(IElement element)
        {
            Effects.Clear();

            SelectedElement = element as IVisualElement;

            switch (element)
            {
                case IVideoElement videoElement:
                    var positionEffect = GetPositionEffect(videoElement);
                    var borderEffect = GetBorderEffect(videoElement);
                    var marginEffect = GetMarginEffect(videoElement);
                    var dropShadowEffect = GetDropShadowEffect(videoElement);
                    var blurEffect = GetBlurEffect(videoElement);
                    Effects.AddRange(new List<EffectsViewModel>() { positionEffect, borderEffect, marginEffect, dropShadowEffect, blurEffect });
                    break;

                case IImageElement imageElement:
                    positionEffect = GetPositionEffect(imageElement);
                    dropShadowEffect = GetDropShadowEffect(imageElement);
                    borderEffect = GetBorderEffect(imageElement);
                    marginEffect = GetMarginEffect(imageElement);
                    blurEffect = GetBlurEffect(imageElement);
                    Effects.AddRange(new List<EffectsViewModel>() { positionEffect, borderEffect, marginEffect, dropShadowEffect, blurEffect });
                    break;

                case IMediaElement mediaElement:
                    break;

                case ITextElement textElement:
                    blurEffect = GetBlurEffect(textElement);
                    positionEffect = GetPositionEffect(textElement);
                    borderEffect = GetBorderEffect(textElement);
                    marginEffect = GetMarginEffect(textElement);
                    dropShadowEffect = GetDropShadowEffect(textElement);
                    Effects.AddRange(new List<EffectsViewModel>() { positionEffect, borderEffect, marginEffect, dropShadowEffect, blurEffect });
                    break;

                case IVisualElement visualElement:
                    blurEffect = GetBlurEffect(visualElement);
                    positionEffect = GetPositionEffect(visualElement);
                    dropShadowEffect = GetDropShadowEffect(visualElement);
                    borderEffect = GetBorderEffect(visualElement);
                    Effects.AddRange(new List<EffectsViewModel>() { positionEffect, borderEffect, dropShadowEffect, blurEffect });
                    break;
            }
        }

        private BlurEffectViewModel GetBlurEffect(IBlurEffect blurEffect)
        {
            return new BlurEffectViewModel(blurEffect);
        }

        private DropShadowViewModel GetDropShadowEffect(IDropShadowEffect dropShadowEffect)
        {
            return new DropShadowViewModel(dropShadowEffect);
        }

        private BorderEffectViewModel GetBorderEffect(IBorderEffect borderEffect)
        {
            return new BorderEffectViewModel(borderEffect);
        }

        private PositionEffectViewModel GetPositionEffect(IPositionEffect positionEffect)
        {
            return new PositionEffectViewModel(positionEffect);
        }

        private MarginEffectViewModel GetMarginEffect(IMarginEffect marginEffect)
        {
            return new MarginEffectViewModel(marginEffect);
        }
    }
}