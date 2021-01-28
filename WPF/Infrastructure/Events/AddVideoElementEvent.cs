using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.Models;
using Prism.Events;

namespace Infrastructure.Events
{
    public class AddVideoElementEvent : PubSubEvent<IElement>
    {
        
    }
}
