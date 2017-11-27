using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class InfoEventArgs : EventArgs
    {
        public InfoEventArgs(DateTime time, object value)
        {
            this.time = time;
            this.value = value;
        }
        public readonly DateTime time;
        public readonly object value;
    }
}
