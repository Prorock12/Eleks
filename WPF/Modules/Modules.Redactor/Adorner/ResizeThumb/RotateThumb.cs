using Modules.Redactor.ViewModels;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class RotateThumb : Thumb
    {
        public RotateThumb()
        {
            DragDelta += RotateThumb_DragDelta;
        }

        private void RotateThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (designerItem != null)
            {
                //EnforceSize(this);

                designerItem.Angle += e.HorizontalChange / 20;
            }
        }
    }
}