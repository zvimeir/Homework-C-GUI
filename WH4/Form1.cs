using HW4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WH4
{
    public partial class Form1 : Form
    {
        //משתנים
        DataFile theFIle = new DataFile();
        QueueFiles theList = new QueueFiles();
        QueueFiles fileByTapy;
        FileTypeExtension tapy;
        //יצירת קובץ
        public Form1()
        {
            InitializeComponent();
        }

        //ניקוי
        private void clear()
        {
            grbAddFile.Visible = false;
            grbByType.Visible = false;
        }
        //בחירת אפשרות
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == -1)
            {
                MessageBox.Show("You choose an option!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (cmbOption.SelectedIndex+1)
            {
                case 1:
                    clear();
                    theFIle = new DataFile();
                    theList.enQueue(theFIle);
                    MessageBox.Show("File added successfully!");
                    break;
                case 2:
                    clear();
                    grbAddFile.Visible = true;
                    break;
                case 3:
                    theList.Dequeue();
                    break;
                case 4:
                    theList.PrintQueue();
                    break;
                case 5:
                    clear();
                    grbByType.Visible = true;
                    break;
                case 6:
                    clear();
                    if (theList.isEmpty())
                    {
                        MessageBox.Show("You need to create some files first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        theFIle = theList.BigFile();
                        MessageBox.Show("The largest file is: \n"+ theFIle.dir());
                    }
                    break;
            }
        }
        private void lblOption_Click(object sender, EventArgs e)
        {

        }
        //אפשרות 2
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbData.Text) ||
                string.IsNullOrWhiteSpace(txbName.Text) ||
                 cmbtape.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill in all the fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                theFIle = new DataFile(txbName.Text, txbData.Text, (FileTypeExtension)cmbtape.SelectedIndex);
                theList.enQueue(theFIle);
                txbName.Text = "";
                txbData.Text = "";
                MessageBox.Show("File added successfully!");
            }
            grbAddFile.Visible = false;
        }

        private void cmbtape_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tapy= (FileTypeExtension)cmbTypeToSearch.SelectedIndex;
            fileByTapy = theList.SearchFileByType(tapy);
            fileByTapy.PrintQueue();
            if (fileByTapy.isEmpty())
                MessageBox.Show("There are no files of this type");
        }
    }
}
