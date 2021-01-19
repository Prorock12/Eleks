using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Interfaces.Models
{
    public interface IElement
    {
        #region Properties

        string Name { get; set; }
        string Id { get; set; }

        #endregion
    }
}
