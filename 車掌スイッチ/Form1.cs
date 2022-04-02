using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Configuration;

namespace 車掌スイッチ
{
    public partial class Form1 : Form
    {
        private string DataFileName = System.IO.Path.Combine(Application.StartupPath, "Setting.xml");
        private DataSet Ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
            {
                this.timer = new System.Windows.Forms.Timer();
                this.timer1 = new System.Windows.Forms.Timer();
            }
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox3;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox4;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox5;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            CloseDoorbutton.Enabled = false;
            openFileDialog2.FileName = AppDomain.CurrentDomain.BaseDirectory + "Setting.xml";
            XMLLoad();
        }

        public System.Media.SoundPlayer player = null;

        //WAVEファイルを再生する
        public void PlaySound(string waveFile)
        {
            //読み込む
            player = new System.Media.SoundPlayer(waveFile);
            //非同期再生する
            player.Play();
         }

       private void ClSndpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpSndpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        public void Clsbutton_Click(object sender, EventArgs e)
        {
            if (ClSndpath.Text == "")
            {
                Form2 form2 = new Form2();
                //フォームを親フォームの真ん中に表示する
                form2.StartPosition = FormStartPosition.CenterParent;
                form2.ShowDialog(this);
                form2.Dispose();
            }
            else
            {
                PlaySound(ClSndpath.Text);
                int Dwidth = Decimal.ToInt32(numwidth.Value);
                OpenDoorbutton.Enabled = true;
                CloseDoorbutton.Enabled = false;
                OpenDoorbutton.Focus();
                this.timer.Enabled = true;
                this.timer.Interval = Decimal.ToInt32(numspeedC.Value);
                this.timer.Tick += new System.EventHandler(this.DoorCls);
                timer1.Stop();
                this.timer1.Enabled = false;
                this.timer1.Tick -= new System.EventHandler(this.DoorOpn);
                timer.Start();
                if (numericUpDown1.Value < 0)
                {
                    timer.Stop();
                    this.timer.Enabled = false;
                    this.timer.Tick -= new System.EventHandler(this.DoorCls);
                }
            }
        }
        public void DoorCls(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numpositionC.Value && numericUpDown1.Value >= numspxC.Value / 100)
            {
                numericUpDown1.Value -= numspxC.Value / 100;
            }
            else if (numericUpDown1.Value >= numratioC.Value * numspxC.Value / 10000)
            {
                numericUpDown1.Value -= numratioC.Value * numspxC.Value / 10000;
            }
        }

        public void Opnbutton_Click(object sender, EventArgs e)
        {
            if (OpSndpath.Text == "")
            {
                Form2 form2 = new Form2();
                //フォームを親フォームの真ん中に表示する
                form2.StartPosition = FormStartPosition.CenterParent;
                form2.ShowDialog(this);
                form2.Dispose();
            }
            else
            {
                PlaySound(OpSndpath.Text);
                CloseDoorbutton.Enabled = true;
                OpenDoorbutton.Enabled = false;
                CloseDoorbutton.Focus();
                this.timer1.Enabled = true;
                this.timer1.Interval = Decimal.ToInt32(numspeedO.Value);
                this.timer1.Tick += new System.EventHandler(this.DoorOpn);
                timer.Stop();
                this.timer.Enabled = false;
                this.timer.Tick -= new System.EventHandler(this.DoorCls);
                timer1.Start();
                if (numericUpDown1.Value > numwidth.Value)
                {
                    timer1.Stop();
                    this.timer1.Enabled = false;
                    this.timer1.Tick -= new System.EventHandler(this.DoorOpn);
                }
            }
        }

        public void DoorOpn(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numwidth.Value - numpositionO.Value && numericUpDown1.Value <= numwidth.Value - numspxC.Value / 100)
            {
                numericUpDown1.Value += numspxO.Value / 100;
             }
            else if (numericUpDown1.Value <= numwidth.Value - numratioC.Value * numspxC.Value / 10000)
            {
                numericUpDown1.Value += numratioO.Value * numspxO.Value / 10000;
            }
        }

        private void ClSlbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "WAVファイル(*.wav)|*.wav|すべてのファイル(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "ドア閉音を選択してください";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ClSndpath.Text = openFileDialog1.FileName;
            }
        }

        private void OpSlbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "WAVファイル(*.wav)|*.wav|すべてのファイル(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "ドア開音を選択してください";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                OpSndpath.Text = openFileDialog1.FileName;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int num = Decimal.ToInt32(numericUpDown1.Value);
                pictureBox1.Left = num;
                pictureBox2.Left = pictureBox1.Left * (-2);
                pictureBox3.Left = pictureBox1.Left;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void imgbutton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "車体の画像を選択してください";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                bodyimgpath.Text = openFileDialog1.FileName;
                var bmp = ImageFileOpen(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
                pictureBox4.Image = bmp;
            }
        }

        private void baseimgpath_TextChanged(object sender, EventArgs e)
        {
            var bmp = ImageFileOpen(bodyimgpath.Text);
            pictureBox1.Image = bmp;
            pictureBox4.Image = bmp;
        }
        private void imgbutton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "左扉の画像を選択してください";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                leftimgpath.Text = openFileDialog1.FileName;
                var bmp = ImageFileOpen(openFileDialog1.FileName);
                pictureBox2.Image = bmp;
            }
        }

        private void leftimgpath_TextChanged(object sender, EventArgs e)
        {
            var bmp = ImageFileOpen(leftimgpath.Text);
            pictureBox2.Image = bmp;
        }

        private void imgbutton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "右扉の画像を選択してください";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                rightimgpath.Text = openFileDialog1.FileName;
                var bmp = ImageFileOpen(openFileDialog1.FileName);
                pictureBox3.Image = bmp;
            }
        }

        private void rightimgpath_TextChanged(object sender, EventArgs e)
        {
            var bmp = ImageFileOpen(rightimgpath.Text);
            pictureBox3.Image = bmp;
        }

        private void imgbutton4_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "車内の画像を選択してください";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                intimgpath.Text = openFileDialog1.FileName;
                var bmp = ImageFileOpen(openFileDialog1.FileName);
                pictureBox5.Image = bmp;
            }
        }

        private void intimgpath_TextChanged(object sender, EventArgs e)
        {
            var bmp = ImageFileOpen(intimgpath.Text);
            pictureBox5.Image = bmp;
        }

        private Bitmap ImageFileOpen(string fileName)
        {
            // 指定したファイルが存在するか？確認
            if (System.IO.File.Exists(fileName) == false) return null;

            // 拡張子の確認
            var ext = System.IO.Path.GetExtension(fileName).ToLower();

            // ファイルの拡張子が対応しているファイルかどうか調べる
            if (ext != ".png")
            {
                return null;
            }

            Bitmap bmp;

            // ファイルストリームでファイルを開く
            using (var fs = new System.IO.FileStream(
                fileName,
                System.IO.FileMode.Open,
                System.IO.FileAccess.Read))
            {
                bmp = new Bitmap(fs);
            }
            return bmp;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numspeed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numspxC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void OpenSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "";
            openFileDialog2.Filter = "設定ファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.Title = "設定ファイルを開く";

            DialogResult dr = openFileDialog2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                XMLLoad();
            }
        }

        private void XMLLoad()
        {
            Ds.Tables.Clear();
            Ds.ReadXml(openFileDialog2.FileName);
            Ds.Tables["data"].AcceptChanges();
            XML_BindingSource.DataSource = Ds.Tables["data"];
            {
                ClSndpath.DataBindings.Clear();
                OpSndpath.DataBindings.Clear();
                bodyimgpath.DataBindings.Clear();
                leftimgpath.DataBindings.Clear();
                rightimgpath.DataBindings.Clear();
                intimgpath.DataBindings.Clear();
                numwidth.DataBindings.Clear();
                numspeedC.DataBindings.Clear();
                numspeedO.DataBindings.Clear();
                numspxC.DataBindings.Clear();
                numspxO.DataBindings.Clear();
                numpositionC.DataBindings.Clear();
                numpositionO.DataBindings.Clear();
                numratioC.DataBindings.Clear();
                numratioO.DataBindings.Clear();
                ClSndpath.DataBindings.Add(new Binding("Text", XML_BindingSource, "CloseSound", true));
                OpSndpath.DataBindings.Add(new Binding("Text", XML_BindingSource, "OpenSound", true));
                bodyimgpath.DataBindings.Add(new Binding("Text", XML_BindingSource, "BodyImage", true));
                leftimgpath.DataBindings.Add(new Binding("Text", XML_BindingSource, "LeftDoorImage", true));
                rightimgpath.DataBindings.Add(new Binding("Text", XML_BindingSource, "RightDoorImage", true));
                intimgpath.DataBindings.Add(new Binding("Text", XML_BindingSource, "InteriorImage", true));
                numwidth.DataBindings.Add(new Binding("Value", XML_BindingSource, "Width", true));
                numspeedC.DataBindings.Add(new Binding("Value", XML_BindingSource, "CloseSpeed", true));
                numspeedO.DataBindings.Add(new Binding("Value", XML_BindingSource, "OpenSpeed", true));
                numspxC.DataBindings.Add(new Binding("Value", XML_BindingSource, "CloseSpeed2", true));
                numspxO.DataBindings.Add(new Binding("Value", XML_BindingSource, "OpenSpeed2", true));
                numpositionC.DataBindings.Add(new Binding("Value", XML_BindingSource, "ClosePosition", true));
                numpositionO.DataBindings.Add(new Binding("Value", XML_BindingSource, "OpenPosition", true));
                numratioC.DataBindings.Add(new Binding("Value", XML_BindingSource, "CloseRatio", true));
                numratioO.DataBindings.Add(new Binding("Value", XML_BindingSource, "OpenRatio", true));
            }
            this.SaveSettingToolStripMenuItem.Enabled = true;

        }

        private void SaveSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "設定ファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "設定ファイルを保存";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Ds.WriteXml(saveFileDialog1.FileName);
                Ds.AcceptChanges();
            }
        }
    }
}
