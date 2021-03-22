using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces.Models;

namespace Modules.Que.Interfaces
{
    public interface IQueViewModel
    {
        #region Properties

        IQue Que { get; set; }

        #endregion Properties
    }
}
