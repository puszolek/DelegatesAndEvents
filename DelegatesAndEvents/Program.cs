using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            PublisherList pl = new PublisherList();
            ListListener listList = new ListListener();
            listList.Subscribe(pl);

            ListListenerSaveToFile listListSave = new ListListenerSaveToFile();
            listListSave.Subscribe(pl);

            pl.Add(1);
            pl.Add("witam");
            pl.Add(Math.PI);

            Thread.Sleep(1000);
            Console.WriteLine("\n");

            pl[0] = 2;

            pl.Clear();

            listListSave.Unsubscribe(pl);

            pl.Add("ostatnia wartosc");

            Thread.Sleep(10000);
        }
    }
}
