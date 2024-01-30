using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    enum FileTypeExtension { TXT = 0, DOC = 1, DOCX = 2, PDF = 3, PPTX = 4 };
    internal class DataFile
    {
        private string FileName;
        private DateTime lastUpadateTime;
        private string Data;
        private FileTypeExtension type ;
        private static int counter; 
        
       
        public string getFileName()
        {
            return this.FileName;
        }
        public bool setFileName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '?' ||
                    name[i] == '/' ||
                    name[i] == '*' ||
                    name[i] == '>' ||
                    name[i] == '<' ||
                    name[i] == ':' ||
                    name[i] == '"'
                    )
                {
                    MessageBox.Show("A file cannot contain signs other than letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
   
            }
           
            this.FileName = name;
            return true; 
        }
        public string getData()
        {
            return this.Data;
        }
        public void setData(string name)
        {
            this.Data = name;
        }
        public void SetTime()
        {
            this.lastUpadateTime = DateTime.Now;
        }
        public DateTime GetTime()
        {
            return this.lastUpadateTime;
        } 
        public FileTypeExtension getType()
        {
            return this.type;
        }
        public DataFile(string newName, string newData, FileTypeExtension typeExtension)
        {
            this.type = typeExtension; 
            setFileName(newName);
            setData(newData);
            SetTime();
        }
        public DataFile() :this("sameFile"+ counter, "",FileTypeExtension.TXT) { counter++; }
        public DataFile(DataFile oldFile)
        {
            this.FileName = oldFile.getFileName() + "1";
            this.Data = oldFile.getData();
            this.SetTime();
        }
        public int GetSize()
        {
           ;  return this.Data.Length;
        }

        public string dir()
        {
           return string.Format("{0} {1} KB {2}. {3}\n", GetTime(), String.Format("{0:0.00}", (GetSize() / 1024)), getFileName(), this.type);
        }

        



    }

}
