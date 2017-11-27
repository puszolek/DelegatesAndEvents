using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class ListListenerSaveToFile
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
            string filename = "C:\\Users\\student.SL228-03\\Desktop\\file.txt";
            string string_to_write = ie.time + " " + ie.value;

            FileStream fileStream;
            StreamWriter streamWriter;
            fileStream = new FileStream(filename, FileMode.Append);
            streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(string_to_write);
            streamWriter.Flush();

            streamWriter.Close();
            fileStream.Close();
        }
    }
}
