using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Interfaces.Models
{
    public interface IMediaElement : IVisualElement
    {
        #region Properties

        string Path { get; set; }

        #endregion
    }
}
