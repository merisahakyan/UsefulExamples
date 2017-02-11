using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IndexersDemo
{
    public class Indexers
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        public Indexers(Dictionary<int, string> dic)
        {
            this.dic = dic;
        }
        public string this[int index]
        {
            get
            {
                if (dic.Keys.Contains(index))
                    return dic[index];
                else
                    throw new KeyNotFoundException("Index out of range");
            }
        }

    }
}
