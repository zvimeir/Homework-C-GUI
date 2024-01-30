using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    internal class QueueFiles
    {
        DataFile[] queue;
        int freeIndex;

        public QueueFiles ()
        {
            this.queue = new DataFile[0];
            freeIndex = -1; 
        }
        public bool isEmpty()
        {
            if( freeIndex == -1 && this.queue == null )
            {
                MessageBox.Show("NO EMPTY SPACE!"); 
                return true;
            }
            return false;
        }
        
        public void enQueue (DataFile newfile)
        {
            
            DataFile[] newqueue = new DataFile[queue.Length+1];
           if(queue.Length == 0 )
            {
                queue = newqueue;
                newqueue[0] = newfile;
                freeIndex++;
                return;
            }
           for(int i = 0; i < queue.Length; i++)
            {

                if (CompareFiles.EqualsFiles(queue[i],newfile) )
                {

                    MessageBox.Show("The file already exist in queue"); 
                    return;
                }
                newqueue[i] = queue[i]; 
            }
            newqueue[queue.Length] = newfile;  
            queue = newqueue;
            freeIndex++;
        }
        public DataFile Dequeue ()
        {
            DataFile[] newqueue = new DataFile[queue.Length-1];
            for(int i = 1; i < queue.Length; i++ )
            {
                newqueue[i - 1] = queue[i];  
            }
            DataFile temp = queue[0];
            freeIndex = queue.Length - 1;
            queue = newqueue;
            return temp;    

            
        }
        public DataFile BigFile ( )
        {
            QueueFiles temp = new QueueFiles();
            temp.enQueue(queue[0]);

            if (queue.Length == 1)
            {
                Console.WriteLine("one slot queue");
                return this.queue[0];
            } 
            foreach (DataFile file in this.queue)
            {
                if (CompareFiles.CompareSizeFiles(file, temp.queue[0]) == 1)
                    temp.queue[0] = file;
            }
            return temp.queue[0];
        }


        public void PrintQueue ( )
        {
            string print= "The files are:";
            if (queue == null)
            {
                MessageBox.Show("There are no details in the list", "Warning", MessageBoxButtons.OK);
                return;
            }
            foreach (DataFile file in this.queue)
            {
                print += "\n\n" + file.dir();
            }
            MessageBox.Show(print, "Print Queue", MessageBoxButtons.OK);
        }

        public QueueFiles SearchFileByType(FileTypeExtension type)
        {

            QueueFiles temp = new QueueFiles();

            if (this.isEmpty()) return null;

            foreach (DataFile file in this.queue)
            {
                if (file.getType() == type)
                {
                    temp.enQueue(file);
                }
            }
            if (!temp.isEmpty())
                return temp;
            else
                return null;
        }
    }
}



