using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesign
{
    public class CustomerPro : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
