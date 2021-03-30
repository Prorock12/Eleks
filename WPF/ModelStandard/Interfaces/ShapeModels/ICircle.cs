namespace ModelStandard.Interfaces.ShapeModels
{
    public interface ICircle : IEllipse
    {
        #region properties

        double Diameter { get; set; }

        #endregion

    }
}
