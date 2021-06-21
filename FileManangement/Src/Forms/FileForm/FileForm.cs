using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManangement
{
    public partial class FileForm : Form
    {
        public bool saveFile;  //是否关闭
        public string fileText;
        public FileForm()
        {
            InitializeComponent();
            saveFile = false;
            fileText = "";
        }

        //public FileForm(string str)
        //{
        //    InitializeComponent();
        //    saveFile = false;
        //    fileText = "";
        //    inputBox.Text = str;
        //}

        private void save_Click(object sender, EventArgs e)
        {
            saveFile = true;
            fileText = inputBox.Text;
            this.Close();
        }
    }
}
