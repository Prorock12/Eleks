using Modules.Redactor.ViewModels;
using System;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class TopVector : ResizeThumb
    {
        public TopVector()
        {
            DragDelta += Top_DragDelta;
        }

        private void Top_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (sender is Thumb topVector && designerItem != null)
            {
                //EnforceSize(this);

                var oldHeight = designerItem.Height;
                var newHeight = Math.Max(oldHeight - e.VerticalChange, topVector.DesiredSize.Height);

                var oldTop = designerItem.Y;
                var newTop = oldTop - (newHeight - oldHeight);
                designerItem.Height = newHeight;
                designerItem.Y = newTop;
            }
            //ResizeTopVector(designerItem, sender, e,false,false);
        }
    }
}