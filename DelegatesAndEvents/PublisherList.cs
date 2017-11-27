using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class PublisherList : ArrayList
    {
        // definitionf of a delegate
        public delegate void ChangeDetectedHandler(object o, InfoEventArgs e);

        // definition of event
        public event ChangeDetectedHandler ChangeDetected;

        // indexer
        override public object this[int key]
        {
            get
            {

                return base[key];
            }
            set
            {
                base[key] = value;
                InfoEventArgs infoEventArgs = new InfoEventArgs(DateTime.Now, value);
                OnSthHappened(infoEventArgs);
            }
        }

        // method to fire the event
        public void OnSthHappened(InfoEventArgs e)
        {
            if (ChangeDetected != null) ChangeDetected(this, e);
        }

        // overrided methods from ArrayList
        public override int Add(object value)
        {
            DateTime time = DateTime.Now;
            ArrayList list = new ArrayList();
            list.Add(value);
            InfoEventArgs infoEventArgs = new InfoEventArgs(time, value);
            OnSthHappened(infoEventArgs);
            Console.WriteLine("Overrided Add method: {0}", value);
            return base.Add(value);
        }

        public override void Clear()
        {
            DateTime time = DateTime.Now;
            InfoEventArgs infoEventArgs = new InfoEventArgs(time, "clear");
            OnSthHappened(infoEventArgs);
            Console.WriteLine("Overrided Clear method");
            base.Clear();
        }
    }
}
