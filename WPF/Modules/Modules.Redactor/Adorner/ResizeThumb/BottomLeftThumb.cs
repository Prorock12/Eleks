using Modules.Redactor.ViewModels;
using System;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class BottomLeftThumb : ResizeThumb
    {
        public BottomLeftThumb()
        {
            DragDelta += BottomLeft_DragDelta;
        }

        private void BottomLeft_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (sender is Thumb topRightCorner && designerItem != null)
            {
                //EnforceSize(this);
                var oldWidth = designerItem.Width;
                var oldHeight = designerItem.Height;

                var newWidth = Math.Max(oldWidth - e.HorizontalChange, topRightCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight + e.VerticalChange, topRightCorner.DesiredSize.Height);

                //var oldLeft = Canvas.GetLeft(element);
                var oldLeft = designerItem.X;
                var newLeft = oldLeft - (newWidth - oldWidth);
                designerItem.Width = newWidth;
                //Canvas.SetLeft(element, newLeft);
                designerItem.X = newLeft;

                designerItem.Height = newHeight;
            }
        }
    }
}