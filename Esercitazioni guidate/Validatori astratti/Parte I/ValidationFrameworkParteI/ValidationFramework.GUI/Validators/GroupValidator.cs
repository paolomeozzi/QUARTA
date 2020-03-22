using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.GUI.Validators
{
    public class GroupValidator:IValidator
    {
        List<IValidator> validatori = new List<IValidator>();

        public void Add(IValidator v)
        {
            validatori.Add(v);
        }
        public bool Validate()
        {
            bool valid = true;
            foreach (var v in validatori)
            {
                valid = valid && v.Validate();
            }
            return valid;
        }
        
    }
}
