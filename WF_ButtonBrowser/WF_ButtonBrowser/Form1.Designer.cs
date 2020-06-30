namespace WF_ButtonBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBox_Xml = new System.Windows.Forms.GroupBox();
            this.Txt_File = new System.Windows.Forms.TextBox();
            this.Btn_Browser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_File = new System.Windows.Forms.Label();
            this.Btn_Upload = new System.Windows.Forms.Button();
            this.GBox_Xml.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_Xml
            // 
            this.GBox_Xml.Controls.Add(this.Btn_Upload);
            this.GBox_Xml.Controls.Add(this.Lbl_File);
            this.GBox_Xml.Controls.Add(this.Btn_Browser);
            this.GBox_Xml.Controls.Add(this.Txt_File);
            this.GBox_Xml.Location = new System.Drawing.Point(12, 12);
            this.GBox_Xml.Name = "GBox_Xml";
            this.GBox_Xml.Size = new System.Drawing.Size(330, 100);
            this.GBox_Xml.TabIndex = 0;
            this.GBox_Xml.TabStop = false;
            this.GBox_Xml.Text = "Upload XML";
            // 
            // Txt_File
            // 
            this.Txt_File.Location = new System.Drawing.Point(6, 38);
            this.Txt_File.Name = "Txt_File";
            this.Txt_File.Size = new System.Drawing.Size(308, 20);
            this.Txt_File.TabIndex = 0;
            // 
            // Btn_Browser
            // 
            this.Btn_Browser.Location = new System.Drawing.Point(6, 64);
            this.Btn_Browser.Name = "Btn_Browser";
            this.Btn_Browser.Size = new System.Drawing.Size(75, 23);
            this.Btn_Browser.TabIndex = 1;
            this.Btn_Browser.Text = "Browser";
            this.Btn_Browser.UseVisualStyleBackColor = true;
            this.Btn_Browser.Click += new System.EventHandler(this.Btn_Browser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lbl_File
            // 
            this.Lbl_File.AutoSize = true;
            this.Lbl_File.Location = new System.Drawing.Point(6, 22);
            this.Lbl_File.Name = "Lbl_File";
            this.Lbl_File.Size = new System.Drawing.Size(26, 13);
            this.Lbl_File.TabIndex = 1;
            this.Lbl_File.Text = "File:";
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Location = new System.Drawing.Point(239, 64);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.Btn_Upload.TabIndex = 2;
            this.Btn_Upload.Text = "Upload";
            this.Btn_Upload.UseVisualStyleBackColor = true;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 128);
            this.Controls.Add(this.GBox_Xml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBox_Xml.ResumeLayout(false);
            this.GBox_Xml.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_Xml;
        private System.Windows.Forms.Button Btn_Browser;
        private System.Windows.Forms.TextBox Txt_File;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Lbl_File;
        private System.Windows.Forms.Button Btn_Upload;
    }
}

