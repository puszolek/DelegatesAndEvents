using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class ListListener
    {
        public void Subscribe(PublisherList pl)
        {
            pl.ChangeDetected += new PublisherList.ChangeDetectedHandler(SthHasChanged);
        }

        public void Unsubscribe(PublisherList pl)
        {
            pl.ChangeDetected -= new PublisherList.ChangeDetectedHandler(SthHasChanged);
        }
        public void SthHasChanged(object pl, InfoEventArgs ie)
        {
            Console.WriteLine("Current Time: {0}, {1}", ie.time, ie.value);
        }
    }
}
