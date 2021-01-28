namespace Models.Interfaces.Models
{
    public interface ITextElement : IVisualElement
    {
        #region Properties

        string Text { get; set; }

        #endregion Properties
    }
}