using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingIterators
{
    public class Derived<T> : IEnumerable, IEnumerator
    {
        List<T> list = new List<T>();
        int index ;

        public Derived(List<T> list)
        {
            this.list = list;
            index = -1;
        }



        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public object Current
        {
            get
            {
                return list[index];
            }
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
