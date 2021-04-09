namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class ResizeCircleThumb : ResizeThumb
    {
        //public ResizeCircleThumb()
        //{
        //    DragDelta += ResizeCircleThumb_DragDelta;
        //}

        //private void ResizeCircleThumb_DragDelta(object sender, DragDeltaEventArgs e)
        //{
        //    var designerItem = ((DataContext as VisualElementViewModel)?.VisualElement as Circle);
        //    if (sender is Thumb bottomRightCorner && designerItem != null)
        //    {
        //        //EnforceSize(this);

        //        var oldWidth = designerItem.Width;
        //        var oldHeight = designerItem.Height;

        //        var newWidth = Math.Max(oldWidth + e.HorizontalChange, bottomRightCorner.DesiredSize.Width);
        //        var newHeight = Math.Max(oldHeight + e.VerticalChange, bottomRightCorner.DesiredSize.Height);

        //        designerItem.Width = newWidth;
        //        designerItem.Height = newHeight;
        //    }
        //    //For TriangleForm
        //    if (designerItem is Triangle triangle)
        //    {
        //        triangle?.Points.Clear();
        //        triangle.Point1 = new Point(0, triangle.Height);
        //        triangle.Point2 = new Point(triangle.Width / 2, 0);
        //        triangle.Point3 = new Point(triangle.Width, triangle.Height);
        //        triangle?.Points.Add(triangle.Point1);
        //        triangle?.Points.Add(triangle.Point2);
        //        triangle?.Points.Add(triangle.Point3);
        //    }
        //}
    }
}