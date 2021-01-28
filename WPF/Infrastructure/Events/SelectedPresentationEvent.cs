using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;
using Prism.Events;

namespace Infrastructure.Events
{
    public class SelectedPresentationEvent : PubSubEvent<IPresentation>
    {
    }
}