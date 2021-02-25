using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Infrastructure
{
    public static class ExtendedColorHelper
    {
        public static List<ExtendedColor> Colors { get; }
        public static List<ExtendedColor> BaseColors { get; }

        static ExtendedColorHelper()
        {
            Colors = GetListExtendedColor();
            //BaseColors = GetListBaseColor();
        }

        private static List<ExtendedColor> GetListExtendedColor()
        {
            return new List<ExtendedColor>()
            {
                GetBlackColor(),
                GetWhiteColor()
            };
        }

        private static List<ExtendedColor> GetListBaseColor()
        {
            return new List<ExtendedColor>()
            {
                GetBlackColor(),
                GetWhiteColor()
            };
        }

        private static ExtendedColor GetBlackColor()
        {
            return new ExtendedColor("Black", Color.FromRgb(0, 0, 0));
        }
        private static ExtendedColor GetWhiteColor()
        {
            return new ExtendedColor("White", Color.FromRgb(255, 255, 255));
        }
    }
}
