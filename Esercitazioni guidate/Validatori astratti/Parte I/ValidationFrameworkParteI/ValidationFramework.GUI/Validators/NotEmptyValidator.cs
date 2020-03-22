using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.GUI.Validators
{
    public class NotEmptyValidator: IValidator
    {
        ValueProvider value;
        public NotEmptyValidator(ValueProvider value)
        {
            this.value = value;
        }

        public bool Validate()
        {
            return value() != "";
        }
    }

}
