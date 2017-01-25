
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Agencies
    {   public string agencyname { get; set; }
        public Agencies(string name)
        {
            agencyname = name;
        }
        public event EventHandler<News> MyNews;
        public void BroadcastNews()
        {
            var args = new News
            {
                Title = "Donald Trump's wife...",
                Date = DateTime.Now
            };
            MyNews?.Invoke(this, args);
        }
        public void BroadcastNews1()
        {
            var args = new News
            {
                Title = "Barac Obama...",
                Date = DateTime.Today
            };
            MyNews?.Invoke(this, args);
        }
        public void BroadcastNews2()
        {
            var args = new News
            {
                Title = "Vladiir Putin...",
                Date = DateTime.Now
            };
            MyNews?.Invoke(this, args);
        }
    }
}
