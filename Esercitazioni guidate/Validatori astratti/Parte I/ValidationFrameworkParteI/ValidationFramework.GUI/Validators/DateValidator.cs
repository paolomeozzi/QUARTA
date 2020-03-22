using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.GUI.Validators
{
    public class DateValidator: IValidator
    {
        ValueProvider value;
        public DateValidator(ValueProvider value)
        {
            this.value = value;
        }

        public bool Validate()
        {
            return DateTime.TryParse(value(), out _);
        }
    }

    
}
