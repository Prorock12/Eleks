namespace Models.Interfaces.Models
{
    public interface IVisualElement : IElement
    {
        #region Properties

        double X { get; set; }
        double Y { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        double Angle { get; set; }

        #endregion Properties
    }
}