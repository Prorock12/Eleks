using Models.Interfaces.Models;
using Prism.Events;

namespace Infrastructure.Events
{
    public class ChangeResolutionSizeEvent : PubSubEvent<IResolution>
    {
    }
}