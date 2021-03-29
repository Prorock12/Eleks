using Modules.Redactor.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using Models.Models.ShapeModels;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class BottomRightThumb : ResizeThumb
    {
        public BottomRightThumb()
        {
            DragDelta += BottomRight_DragDelta;
        }

        private void BottomRight_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (sender is Thumb bottomRightCorner && designerItem != null)
            {
                //EnforceSize(this);

                var oldWidth = designerItem.Width;
                var oldHeight = designerItem.Height;

                var newWidth = Math.Max(oldWidth + e.HorizontalChange, bottomRightCorner.DesiredSize.Width);
                var newHeight = Math.Max(oldHeight + e.VerticalChange, bottomRightCorner.DesiredSize.Height);

                designerItem.Width = newWidth;
                designerItem.Height = newHeight;
            }
        }
    }
}