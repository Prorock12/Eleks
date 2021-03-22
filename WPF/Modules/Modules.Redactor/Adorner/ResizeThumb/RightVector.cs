using Modules.Redactor.ViewModels;
using System;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class RightVector : ResizeThumb
    {
        public RightVector()
        {
            DragDelta += Right_DragDelta;
        }

        private void Right_DragDelta(object sender, DragDeltaEventArgs e)
        {

            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;

            if (sender is Thumb rightVector && designerItem != null)
            {
                //EnforceSize(this);

                var oldWidth = designerItem.Width;

                var newWidth = Math.Max(oldWidth + e.HorizontalChange, rightVector.DesiredSize.Width);
                designerItem.Width = newWidth;
            }
            //ResizeRightVector(designerItem, sender, e,false);
        }
    }
}