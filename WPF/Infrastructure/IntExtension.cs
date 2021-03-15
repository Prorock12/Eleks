using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class IntExtension
    {
        public static int Clamp(this int value, int min, int max)
        {
            int result = value < min ? min : value > max ? max : value;
            return result;
        }
    }
}
