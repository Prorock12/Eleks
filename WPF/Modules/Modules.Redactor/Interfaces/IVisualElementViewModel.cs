using Models.Interfaces.Models;

namespace Modules.Redactor.Interfaces
{
    public interface IVisualElementViewModel : IElementViewModel
    {
        IVisualElement VisualElement { get; set; }
    }
}