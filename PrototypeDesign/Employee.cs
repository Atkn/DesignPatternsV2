using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesign
{
    public class Employee : Person
    {
        public decimal Summary { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
