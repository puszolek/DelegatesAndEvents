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
            int day;
            int month;
            int year;
            GetTimes(ie.time, out day, out month, out year);
            Console.WriteLine("Current Time: {0}, {1}", ie.time, ie.value);
        }

        public void GetTimes(DateTime time, out int day, out int month, out int year)
        {
            day = time.Day;
            month = time.Month;
            year = time.Year;
        }
    }
}
