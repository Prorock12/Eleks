namespace Models.Interfaces.Models
{
    public interface IMediaElement : IVisualElement
    {
        #region Properties

        string Path { get; set; }

        #endregion Properties
    }
}