using Models.Interfaces.Models;

namespace Modules.Redactor.Interfaces
{
    public interface IImageElementViewModel : IMediaElementViewModel
    {
        IImageElement ImageElement { get; set; }
    }
}