using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Interfaces.Models
{
    public interface ITextElement : IVisualElement
    {
        #region Properties

        string Text { get; set; }

        #endregion
    }
}
