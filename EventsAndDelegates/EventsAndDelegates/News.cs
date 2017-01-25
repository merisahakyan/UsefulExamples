using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class News: EventArgs
    { public string Title { get; set; }
     public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"{Title}:  {Date}";
        }
    }
}
