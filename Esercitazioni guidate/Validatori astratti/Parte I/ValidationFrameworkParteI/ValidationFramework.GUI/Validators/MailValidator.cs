using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.GUI.Validators
{
    public class MailValidator: IValidator
    {
        ValueProvider value;
        public MailValidator(ValueProvider value)
        {
            this.value = value;
        }

        char[] sep = { '@' };
        public bool Validate()
        {
            string[] items = value().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            return items.Length == 2;
        }
    }
}
