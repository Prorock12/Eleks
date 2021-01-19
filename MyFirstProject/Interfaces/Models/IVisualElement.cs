using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Interfaces.Models
{
    public interface IVisualElement : IElement
    {
        #region Properties

        double X { get; set; }
        double Y { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        double Angle { get; set; }

        #endregion
    }
}