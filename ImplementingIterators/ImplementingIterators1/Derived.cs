using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingIterators1
{
    public class Derived<T> : IEnumerable, IEnumerator

    {
        List<T> list = new List<T>();
        int index;
        public Derived(List<T> list)
        {
            this.list = list;
            index = -1;
        }
        public object Current
        {
            get
            {
                return this.list[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public bool MoveNext()
        {
            if (index + 1 < list.Count)
            {
                index++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
