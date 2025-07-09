using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace XMLtoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void btnBrowse_click(object sender, EventArgs e)
        {
            //if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //txtFilePath.Text = OFD.FileName;
        }
    }
}
