using Modules.Redactor.ViewModels;
using System;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class TopRightThumb : ResizeThumb
    {
        public TopRightThumb()
        {
            DragDelta += TopRight_DragDelta;
        }

        private void TopRight_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (sender is Thumb topRightCorner && designerItem != null)
            {
                //EnforceSize(this);
                var oldWidth = designerItem.Width;
                var oldHeight = designerItem.Height;

                var newWidth = Math.Max(oldWidth + e.HorizontalChange, topRightCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight - e.VerticalChange, topRightCorner.DesiredSize.Height);
                designerItem.Width = newWidth;

                var oldTop = designerItem.Y;
                var newTop = oldTop - (newHeight - oldHeight);
                designerItem.Height = newHeight;
                designerItem.Y = newTop;
            }
        }
    }
}