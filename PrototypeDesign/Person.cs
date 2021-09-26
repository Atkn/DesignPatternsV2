using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesign
{
    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

   
}
