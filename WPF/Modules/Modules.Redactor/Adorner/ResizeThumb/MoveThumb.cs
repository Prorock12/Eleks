using Modules.Redactor.ViewModels;
using System.Windows.Controls.Primitives;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class MoveThumb : Thumb
    {
        public MoveThumb()
        {
            DragDelta += Move_DragDelta;
        }

        private void Move_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var designerItem = (DataContext as VisualElementViewModel)?.VisualElement;
            if (designerItem != null)
            {
                designerItem.X = designerItem.X + e.HorizontalChange;
                designerItem.Y = designerItem.Y + e.VerticalChange;
            }
        }
    }
}