using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using Template.Models;

namespace WF_ButtonBrowser
{
    public partial class Form1 : Form
    {
        private XmlTextReader XmlTextReader_;

        private List<Client> ListClients_;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Browser_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                Txt_File.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            
        }
    }
}   