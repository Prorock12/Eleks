using Prism.Events;

namespace Infrastructure.Events
{
    public class SendObjectForEffect : PubSubEvent<object>
    {
    }
}