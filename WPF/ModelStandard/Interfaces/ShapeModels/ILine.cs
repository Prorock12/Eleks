namespace ModelStandard.Interfaces.ShapeModels
{
    public interface ILine : IShape
    {
        #region properties

        double X1 { get; set; }
        double X2 { get; set; }
        double Y1 { get; set; }
        double Y2 { get; set; }

        #endregion
    }
}
