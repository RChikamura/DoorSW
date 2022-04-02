using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsBindingNavigator
{
    public partial class BindingNavigator_Form : Form
    {
        private string DataFileName = System.IO.Path.Combine(Application.StartupPath, 
                                                             "data.xml");
        private DataSet Ds = new DataSet();

        public BindingNavigator_Form()
        {
            InitializeComponent();
        }

        private void FileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ds.Tables.Clear();
            Ds.ReadXml(DataFileName);
            Ds.Tables["data"].AcceptChanges();
            this.XML_BindingSource.DataSource = Ds.Tables["data"];
            {
                this.Date_TextBox.DataBindings.Add(new Binding("Text",
                                                             this.XML_BindingSource,
                                                             "日付",
                                                             true));
                this.Title_TextBox.DataBindings.Add(new Binding("Text",
                                                              this.XML_BindingSource,
                                                              "タイトル",
                                                              true));
                this.URL_TextBox.DataBindings.Add(new Binding("Text",
                                                            this.XML_BindingSource,
                                                            "URL",
                                                            true));
                this.VB_CheckBox.DataBindings.Add(new Binding("CheckState",
                                                            this.XML_BindingSource,
                                                            "vb",
                                                            true));
                this.Oracle_CheckBox.DataBindings.Add(new Binding("CheckState",
                                                                this.XML_BindingSource,
                                                                "oracle",
                                                                true));
            }
            this.FileSaveToolStripMenuItem.Enabled = true;
        }

        private void FileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ds.WriteXml(DataFileName);
            Ds.AcceptChanges();
        }

        private void FileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
