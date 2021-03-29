using Modules.Redactor.ViewModels;
using System;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class LeftVector : ResizeThumb
    {
        public LeftVector()
        {
            DragDelta += Left_DragDelta;
        }

        private void Left_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (sender is Thumb leftVector && designerItem != null)
            {
                //EnforceSize(this);

                var oldWidth = designerItem.Width;

                var temporaryWidth = Math.Max(oldWidth + e.HorizontalChange, leftVector.DesiredSize.Width);

                var newWidth = oldWidth - (temporaryWidth - oldWidth);

                var oldLeft = designerItem.X;
                var newLeft = oldLeft + e.HorizontalChange;
                designerItem.Width = newWidth;
                designerItem.X = newLeft;
            }
            //ResizeLeftVector(designerItem, sender,e,false,false);
        }
    }
}