using Models.Interfaces.Models;

namespace Modules.Redactor.Interfaces
{
    public interface IElementViewModel
    {
        IElement Element { get; set; }
    }
}