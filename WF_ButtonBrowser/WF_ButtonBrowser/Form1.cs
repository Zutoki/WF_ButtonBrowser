using System;
using System.IO;
using System.Windows.Forms;

namespace WF_ButtonBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Browser_Click(object sender, EventArgs e)
        {
            try
            {
                var ChooseXml = new OpenFileDialog();
                var ChoseXmlResult_ = ChooseXml.ShowDialog(); // Show the dialog.
                ChooseXml.Filter = "XML Files (*.xml)|*.xml";
                ChooseXml.DefaultExt = "xml";
                ChooseXml.Multiselect = false;
                if (ChoseXmlResult_ == DialogResult.OK) // Test result.
                {
                    var ext = Path.GetExtension(ChooseXml.FileName);
                    if (!String.Equals(ext, ".xml", StringComparison.OrdinalIgnoreCase)) throw new Exception("Type of the selected file isn't supported.");
                    Txt_File.Text = ChooseXml.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Txt_File.Text = "";
            }
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            
        }
    }
}   