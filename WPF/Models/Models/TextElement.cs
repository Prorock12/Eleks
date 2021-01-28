using Models.Interfaces.Models;

namespace Models.Models
{
    public class TextElement : VisualElement, ITextElement
    {
        #region Fields

        private string _text;

        #endregion Fields

        #region Properties

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        #endregion Properties

        public TextElement(string name) : base(name)
        {

        }
    }
}