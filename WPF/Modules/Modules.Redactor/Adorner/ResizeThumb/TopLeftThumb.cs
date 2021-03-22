using Modules.Redactor.ViewModels;
using System;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class TopLeftThumb : ResizeThumb
    {
        public TopLeftThumb()
        {
            DragDelta += TopLeft_DragDelta;
        }

        private void TopLeft_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (sender is Thumb topLeftCorner && designerItem != null)
            {
                //EnforceSize(this);
                var oldWidth = designerItem.Width;
                var oldHeight = designerItem.Height;

                var newWidth = Math.Max(oldWidth - e.HorizontalChange, topLeftCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight - e.VerticalChange, topLeftCorner.DesiredSize.Height);

                var oldLeft = designerItem.X;
                var newLeft = oldLeft - (newWidth - oldWidth);
                designerItem.Width = newWidth;
                designerItem.X = newLeft;

                var oldTop = designerItem.Y;
                var newTop = oldTop - (newHeight - oldHeight);
                designerItem.Height = newHeight;
                designerItem.Y = newTop;
            }
        }
    }
}