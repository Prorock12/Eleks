using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces.Models
{
    public interface IQue
    {
        string Name { get; set; }
        
        ObservableCollection<ISlide> Slides { get; set; }
    }
}
