using Modules.Redactor.ViewModels;
using System;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class BottomVector : ResizeThumb
    {
        public BottomVector()
        {
            DragDelta += Bottom_DragDelta;
        }

        private void Bottom_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            //int result = (int)(designerItem?.Angle % 360) / 45;
            //switch (result)
            //{
            //    case 0:
            //    case 7:
            //        ResizeBottomVector(designerItem, sender, e);
            //        break;
            //    case 1:
            //    case 2:
            //        ResizeLeftVector(designerItem, sender, e,true,true);
            //        break;
            //    case 3:
            //    case 4:
            //        ResizeTopVector(designerItem, sender, e , false,true);
            //        break;
            //    case 5:
            //    case 6:
            //        ResizeRightVector(designerItem, sender, e,true);
            //        break;
            //}
            if (sender is Thumb bottomVector && designerItem != null)
            {
                //EnforceSize(this);

                var oldHeight = designerItem.Height;

                var newHeight = Math.Max(oldHeight + e.VerticalChange, bottomVector.DesiredSize.Height);
                designerItem.Height = newHeight;
            }
            //ResizeBottomVector(designerItem, sender, e);
        }
    }
}