using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Infrastructure
{
    public class EnumBindingSourceExtention : MarkupExtension
    {
        public Type EnumType { get; private set; }

        public EnumBindingSourceExtention(Type enumType)
        {
            if (enumType is null || !enumType.IsEnum)
                throw new Exception("Enum must not be null or be an enum");
            EnumType = enumType;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}
