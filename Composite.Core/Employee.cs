using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite.Core
{
    public class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subOrdinates = new List<IPerson>();
        public void AddSubOrdinate(IPerson person)
        {
            _subOrdinates.Add(person);
        }
        public void RemoveSubOrdinate(IPerson person)
        {
            _subOrdinates.Remove(person);
        }
        public IPerson GetSubOrdinate(int index)
        {
            return _subOrdinates[index];
        }
        public string Name { get; set; }
        public bool IsSubMember { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var item in _subOrdinates)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
