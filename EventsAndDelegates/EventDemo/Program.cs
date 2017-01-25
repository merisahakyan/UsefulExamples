using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsAndDelegates;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Agencies[] agencies = { new Agencies("BBC"), new Agencies("CNN"), new Agencies("RTR") };
            foreach (var item in agencies)
            {
                item.MyNews += ShowNews;
            }


            agencies[0].BroadcastNews();
            agencies[1].BroadcastNews1();
            agencies[2].BroadcastNews2();

        }
        private static void ShowNews(object sender,EventArgs e)
        {
            var agency = (Agencies)sender ;
            if(agency!=null)
                Console.WriteLine($"{agency.agencyname}:   {e.ToString()}");
        }
    }
}
