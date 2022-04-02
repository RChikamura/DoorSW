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

namespace 車掌スイッチ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PlaySound("C:\\Windows\\Media\\Windows Background.wav");
        }

        private System.Media.SoundPlayer player = null;

        //WAVEファイルを再生する
        public void PlaySound(string waveFile)
        {
            //読み込む
            player = new System.Media.SoundPlayer(waveFile);
            //非同期再生する
            player.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
