using Models.Interfaces.Models;

namespace Modules.Redactor.Interfaces
{
    public interface ITextElementViewModel : IVisualElementViewModel
    {
        ITextElement TextElement { get; set; }
    }
}