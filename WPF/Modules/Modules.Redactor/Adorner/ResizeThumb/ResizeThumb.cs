using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Redactor.ViewModels;

namespace Modules.Redactor.Adorner.ResizeThumb
{
    public class ResizeThumb : Thumb
    {
        public void EnforceSize(FrameworkElement element)
        {
            if (element.Width.Equals(Double.NaN))
                element.Width = element.DesiredSize.Width;
            if (element.Height.Equals(Double.NaN))
                element.Height = element.DesiredSize.Height;

            if (element.Parent is FrameworkElement parent)
            {
                element.MaxHeight = parent.ActualHeight;
                element.MaxWidth = parent.ActualWidth;
            }
        }

        //protected void ResizeLeftVector(IVisualElement designerItem, object sender, DragDeltaEventArgs e, bool isChangeСoordinates, bool isChangeOperation)
        //{
        //    if (sender is Thumb leftVector && designerItem != null)
        //    {
        //        //EnforceSize(this);

        //        double temporaryWidth;
        //        var oldWidth = (isChangeСoordinates) ? designerItem.Height : designerItem.Width;

        //        //if(isChangeOperation)
        //        //    temporaryWidth = Math.Max(oldWidth + e.HorizontalChange, leftVector.DesiredSize.Width);
        //        //else
        //        //{
        //            temporaryWidth = Math.Max(oldWidth - e.HorizontalChange, leftVector.DesiredSize.Width);
        //        //}

        //        var newWidth = oldWidth - (temporaryWidth - oldWidth);

        //        var oldLeft = designerItem.X;
        //        var newLeft = oldLeft + (temporaryWidth - oldWidth);
        //        if(isChangeСoordinates)
        //            designerItem.Width = newWidth;
        //        else
        //        {
                    
        //        }
        //        designerItem.X = newLeft;
        //    }
        //}
        //protected void ResizeRightVector(IVisualElement designerItem, object sender, DragDeltaEventArgs e, bool IsHorizontalVerticalChanged)
        //{
        //    if (sender is Thumb rightVector && designerItem != null)
        //    {
        //        //EnforceSize(this);
        //        var changedWidth = (IsHorizontalVerticalChanged) ? designerItem.Height : designerItem.Width;
        //        //var horizontalChange = (IsHorizontalVerticalChanged) ? e.VerticalChange : e.HorizontalChange;
        //        var verticalChange = (IsHorizontalVerticalChanged) ? e.HorizontalChange : e.VerticalChange;

        //        var oldWidth = changedWidth;


        //        var newWidth = Math.Max(oldWidth + e.HorizontalChange, rightVector.DesiredSize.Width);

        //        ////if(IsHorizontalVerticalChanged)
        //        //     designerItem.Height = newWidth;
        //        ////else
        //        ////{
        //        designerItem.Width = newWidth;
        //        ////}
        //    }
        //}

        //protected void ResizeTopVector(IVisualElement designerItem, object sender, DragDeltaEventArgs e, bool isChangeСoordinates, bool isChangeOperation)
        //{
        //    if (sender is Thumb topVector && designerItem != null)
        //    {
        //        //EnforceSize(this);
        //        double newHeight;
        //        var oldHeight = designerItem.Height;
        //        if(isChangeOperation)
        //            newHeight = Math.Max(oldHeight + e.VerticalChange, topVector.DesiredSize.Height);
        //        else
        //        {
        //            newHeight = Math.Max(oldHeight - e.VerticalChange, topVector.DesiredSize.Height);
        //        }

        //        var oldTop = designerItem.Y;
        //        var newTop = oldTop - (newHeight - oldHeight);
        //        designerItem.Height = newHeight;
        //        designerItem.Y = newTop;
        //    }
        //}
        //protected void ResizeBottomVector(IVisualElement designerItem, object sender, DragDeltaEventArgs e)
        //{
        //    if (sender is Thumb bottomVector && designerItem != null)
        //    {
        //        //EnforceSize(this);

        //        var oldHeight = designerItem.Height;

        //        var newHeight = Math.Max(oldHeight + e.VerticalChange, bottomVector.DesiredSize.Height);
        //        designerItem.Height = newHeight;
        //    }
        //}
    }
}