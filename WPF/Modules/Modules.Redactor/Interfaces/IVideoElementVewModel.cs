using Models.Interfaces.Models;

namespace Modules.Redactor.Interfaces
{
    public interface IVideoElementViewModel : IMediaElementViewModel
    {
        IVideoElement VideoElement { get; set; }
    }
}