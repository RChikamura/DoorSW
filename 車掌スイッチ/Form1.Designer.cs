
namespace 車掌スイッチ
{
    partial class Form1
    {
        private System.Windows.Forms.Timer timer;        /// <summary>
        private System.Windows.Forms.Timer timer1;        /// <summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CloseSelectbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ClSndpath = new System.Windows.Forms.TextBox();
            this.CloseDoorbutton = new System.Windows.Forms.Button();
            this.OpenDoorbutton = new System.Windows.Forms.Button();
            this.OpSndpath = new System.Windows.Forms.TextBox();
            this.OpenSelectbutton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.leftimgpath = new System.Windows.Forms.TextBox();
            this.leftselectbtn = new System.Windows.Forms.Button();
            this.bodyimgpath = new System.Windows.Forms.TextBox();
            this.bodyselectbtn = new System.Windows.Forms.Button();
            this.intimgpath = new System.Windows.Forms.TextBox();
            this.intselectbtn = new System.Windows.Forms.Button();
            this.rightimgpath = new System.Windows.Forms.TextBox();
            this.rightselectbtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numwidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numpositionC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numratioC = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numpositionO = new System.Windows.Forms.NumericUpDown();
            this.numratioO = new System.Windows.Forms.NumericUpDown();
            this.numspeedC = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numspeedO = new System.Windows.Forms.NumericUpDown();
            this.numspxO = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numspxC = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XML_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpositionC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numratioC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpositionO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numratioO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspeedC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspeedO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspxO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspxC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XML_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseSelectbutton
            // 
            this.CloseSelectbutton.Location = new System.Drawing.Point(80, 497);
            this.CloseSelectbutton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseSelectbutton.Name = "CloseSelectbutton";
            this.CloseSelectbutton.Size = new System.Drawing.Size(62, 19);
            this.CloseSelectbutton.TabIndex = 2;
            this.CloseSelectbutton.Text = "音声選択";
            this.CloseSelectbutton.UseVisualStyleBackColor = true;
            this.CloseSelectbutton.Click += new System.EventHandler(this.ClSlbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ClSndpath
            // 
            this.ClSndpath.Location = new System.Drawing.Point(148, 496);
            this.ClSndpath.Margin = new System.Windows.Forms.Padding(2);
            this.ClSndpath.Name = "ClSndpath";
            this.ClSndpath.Size = new System.Drawing.Size(256, 19);
            this.ClSndpath.TabIndex = 4;
            this.ClSndpath.TextChanged += new System.EventHandler(this.ClSndpath_TextChanged);
            // 
            // CloseDoorbutton
            // 
            this.CloseDoorbutton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.CloseDoorbutton.Location = new System.Drawing.Point(11, 482);
            this.CloseDoorbutton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseDoorbutton.Name = "CloseDoorbutton";
            this.CloseDoorbutton.Size = new System.Drawing.Size(65, 34);
            this.CloseDoorbutton.TabIndex = 1;
            this.CloseDoorbutton.Text = "閉";
            this.CloseDoorbutton.UseVisualStyleBackColor = true;
            this.CloseDoorbutton.Click += new System.EventHandler(this.Clsbutton_Click);
            // 
            // OpenDoorbutton
            // 
            this.OpenDoorbutton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.OpenDoorbutton.Location = new System.Drawing.Point(11, 520);
            this.OpenDoorbutton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenDoorbutton.Name = "OpenDoorbutton";
            this.OpenDoorbutton.Size = new System.Drawing.Size(65, 34);
            this.OpenDoorbutton.TabIndex = 0;
            this.OpenDoorbutton.Text = "開";
            this.OpenDoorbutton.UseVisualStyleBackColor = true;
            this.OpenDoorbutton.Click += new System.EventHandler(this.Opnbutton_Click);
            // 
            // OpSndpath
            // 
            this.OpSndpath.Location = new System.Drawing.Point(148, 534);
            this.OpSndpath.Margin = new System.Windows.Forms.Padding(2);
            this.OpSndpath.Name = "OpSndpath";
            this.OpSndpath.Size = new System.Drawing.Size(256, 19);
            this.OpSndpath.TabIndex = 5;
            this.OpSndpath.TextChanged += new System.EventHandler(this.OpSndpath_TextChanged);
            // 
            // OpenSelectbutton
            // 
            this.OpenSelectbutton.Location = new System.Drawing.Point(80, 535);
            this.OpenSelectbutton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenSelectbutton.Name = "OpenSelectbutton";
            this.OpenSelectbutton.Size = new System.Drawing.Size(62, 19);
            this.OpenSelectbutton.TabIndex = 3;
            this.OpenSelectbutton.Text = "音声選択";
            this.OpenSelectbutton.UseVisualStyleBackColor = true;
            this.OpenSelectbutton.Click += new System.EventHandler(this.OpSlbutton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 450);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 450);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(800, 450);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // leftimgpath
            // 
            this.leftimgpath.Location = new System.Drawing.Point(474, 534);
            this.leftimgpath.Margin = new System.Windows.Forms.Padding(2);
            this.leftimgpath.Name = "leftimgpath";
            this.leftimgpath.Size = new System.Drawing.Size(324, 19);
            this.leftimgpath.TabIndex = 9;
            this.leftimgpath.TextChanged += new System.EventHandler(this.leftimgpath_TextChanged);
            // 
            // leftselectbtn
            // 
            this.leftselectbtn.Location = new System.Drawing.Point(408, 519);
            this.leftselectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.leftselectbtn.Name = "leftselectbtn";
            this.leftselectbtn.Size = new System.Drawing.Size(62, 34);
            this.leftselectbtn.TabIndex = 8;
            this.leftselectbtn.Text = "左扉画像選択";
            this.leftselectbtn.UseVisualStyleBackColor = true;
            this.leftselectbtn.Click += new System.EventHandler(this.imgbutton2_Click);
            // 
            // bodyimgpath
            // 
            this.bodyimgpath.Location = new System.Drawing.Point(474, 496);
            this.bodyimgpath.Margin = new System.Windows.Forms.Padding(2);
            this.bodyimgpath.Name = "bodyimgpath";
            this.bodyimgpath.Size = new System.Drawing.Size(324, 19);
            this.bodyimgpath.TabIndex = 7;
            this.bodyimgpath.TextChanged += new System.EventHandler(this.baseimgpath_TextChanged);
            // 
            // bodyselectbtn
            // 
            this.bodyselectbtn.Location = new System.Drawing.Point(408, 482);
            this.bodyselectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.bodyselectbtn.Name = "bodyselectbtn";
            this.bodyselectbtn.Size = new System.Drawing.Size(62, 34);
            this.bodyselectbtn.TabIndex = 6;
            this.bodyselectbtn.Text = "車体画像選択";
            this.bodyselectbtn.UseVisualStyleBackColor = true;
            this.bodyselectbtn.Click += new System.EventHandler(this.imgbutton1_Click);
            // 
            // intimgpath
            // 
            this.intimgpath.Location = new System.Drawing.Point(474, 611);
            this.intimgpath.Margin = new System.Windows.Forms.Padding(2);
            this.intimgpath.Name = "intimgpath";
            this.intimgpath.Size = new System.Drawing.Size(324, 19);
            this.intimgpath.TabIndex = 13;
            this.intimgpath.TextChanged += new System.EventHandler(this.intimgpath_TextChanged);
            // 
            // intselectbtn
            // 
            this.intselectbtn.Location = new System.Drawing.Point(408, 596);
            this.intselectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.intselectbtn.Name = "intselectbtn";
            this.intselectbtn.Size = new System.Drawing.Size(62, 34);
            this.intselectbtn.TabIndex = 12;
            this.intselectbtn.Text = "車内画像選択";
            this.intselectbtn.UseVisualStyleBackColor = true;
            this.intselectbtn.Click += new System.EventHandler(this.imgbutton4_Click);
            // 
            // rightimgpath
            // 
            this.rightimgpath.Location = new System.Drawing.Point(474, 573);
            this.rightimgpath.Margin = new System.Windows.Forms.Padding(2);
            this.rightimgpath.Name = "rightimgpath";
            this.rightimgpath.Size = new System.Drawing.Size(324, 19);
            this.rightimgpath.TabIndex = 11;
            this.rightimgpath.TextChanged += new System.EventHandler(this.rightimgpath_TextChanged);
            // 
            // rightselectbtn
            // 
            this.rightselectbtn.Location = new System.Drawing.Point(408, 559);
            this.rightselectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.rightselectbtn.Name = "rightselectbtn";
            this.rightselectbtn.Size = new System.Drawing.Size(62, 34);
            this.rightselectbtn.TabIndex = 10;
            this.rightselectbtn.Text = "右扉画像選択";
            this.rightselectbtn.UseVisualStyleBackColor = true;
            this.rightselectbtn.Click += new System.EventHandler(this.imgbutton3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(822, 39);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numwidth
            // 
            this.numwidth.Location = new System.Drawing.Point(32, 599);
            this.numwidth.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numwidth.Name = "numwidth";
            this.numwidth.Size = new System.Drawing.Size(65, 19);
            this.numwidth.TabIndex = 14;
            this.numwidth.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "扉の開口幅";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 618);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "開";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "閉";
            // 
            // numpositionC
            // 
            this.numpositionC.Location = new System.Drawing.Point(245, 586);
            this.numpositionC.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numpositionC.Name = "numpositionC";
            this.numpositionC.Size = new System.Drawing.Size(65, 19);
            this.numpositionC.TabIndex = 19;
            this.numpositionC.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = " 減速位置 ";
            // 
            // numratioC
            // 
            this.numratioC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numratioC.Location = new System.Drawing.Point(316, 586);
            this.numratioC.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numratioC.Name = "numratioC";
            this.numratioC.Size = new System.Drawing.Size(65, 19);
            this.numratioC.TabIndex = 21;
            this.numratioC.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = " 減速割合 ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numpositionO
            // 
            this.numpositionO.Location = new System.Drawing.Point(245, 611);
            this.numpositionO.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numpositionO.Name = "numpositionO";
            this.numpositionO.Size = new System.Drawing.Size(65, 19);
            this.numpositionO.TabIndex = 20;
            this.numpositionO.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numratioO
            // 
            this.numratioO.Location = new System.Drawing.Point(316, 611);
            this.numratioO.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numratioO.Name = "numratioO";
            this.numratioO.Size = new System.Drawing.Size(65, 19);
            this.numratioO.TabIndex = 22;
            this.numratioO.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numspeedC
            // 
            this.numspeedC.Location = new System.Drawing.Point(103, 586);
            this.numspeedC.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.numspeedC.Name = "numspeedC";
            this.numspeedC.Size = new System.Drawing.Size(65, 19);
            this.numspeedC.TabIndex = 15;
            this.numspeedC.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numspeedC.ValueChanged += new System.EventHandler(this.numspeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = " 動作速度 ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numspeedO
            // 
            this.numspeedO.Location = new System.Drawing.Point(103, 611);
            this.numspeedO.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.numspeedO.Name = "numspeedO";
            this.numspeedO.Size = new System.Drawing.Size(65, 19);
            this.numspeedO.TabIndex = 16;
            this.numspeedO.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numspxO
            // 
            this.numspxO.Location = new System.Drawing.Point(174, 611);
            this.numspxO.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numspxO.Name = "numspxO";
            this.numspxO.Size = new System.Drawing.Size(65, 19);
            this.numspxO.TabIndex = 18;
            this.numspxO.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = " 倍速設定 ";
            // 
            // numspxC
            // 
            this.numspxC.Location = new System.Drawing.Point(174, 586);
            this.numspxC.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numspxC.Name = "numspxC";
            this.numspxC.Size = new System.Drawing.Size(65, 19);
            this.numspxC.TabIndex = 17;
            this.numspxC.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numspxC.ValueChanged += new System.EventHandler(this.numspxC_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSettingToolStripMenuItem,
            this.SaveSettingToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // OpenSettingToolStripMenuItem
            // 
            this.OpenSettingToolStripMenuItem.Name = "OpenSettingToolStripMenuItem";
            this.OpenSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenSettingToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.OpenSettingToolStripMenuItem.Text = "設定ファイルを開く";
            this.OpenSettingToolStripMenuItem.Click += new System.EventHandler(this.OpenSettingToolStripMenuItem_Click);
            // 
            // SaveSettingToolStripMenuItem
            // 
            this.SaveSettingToolStripMenuItem.Name = "SaveSettingToolStripMenuItem";
            this.SaveSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveSettingToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.SaveSettingToolStripMenuItem.Text = "設定ファイルを保存";
            this.SaveSettingToolStripMenuItem.Click += new System.EventHandler(this.SaveSettingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numspxO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numspxC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numratioO);
            this.Controls.Add(this.numpositionO);
            this.Controls.Add(this.numspeedO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numratioC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numpositionC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numspeedC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numwidth);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.intimgpath);
            this.Controls.Add(this.intselectbtn);
            this.Controls.Add(this.rightimgpath);
            this.Controls.Add(this.rightselectbtn);
            this.Controls.Add(this.leftimgpath);
            this.Controls.Add(this.leftselectbtn);
            this.Controls.Add(this.bodyimgpath);
            this.Controls.Add(this.bodyselectbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.OpenDoorbutton);
            this.Controls.Add(this.OpSndpath);
            this.Controls.Add(this.OpenSelectbutton);
            this.Controls.Add(this.CloseDoorbutton);
            this.Controls.Add(this.ClSndpath);
            this.Controls.Add(this.CloseSelectbutton);
            this.Controls.Add(this.pictureBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "簡易車掌スイッチシミュレーター";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpositionC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numratioC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpositionO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numratioO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspeedC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspeedO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspxO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numspxC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XML_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDoorbutton;
        private System.Windows.Forms.Button CloseDoorbutton;
        private System.Windows.Forms.Button CloseSelectbutton;
        internal System.Windows.Forms.TextBox ClSndpath;
        private System.Windows.Forms.Button OpenSelectbutton;
        internal System.Windows.Forms.TextBox OpSndpath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button bodyselectbtn;
        internal System.Windows.Forms.TextBox bodyimgpath;
        private System.Windows.Forms.Button leftselectbtn;
        internal System.Windows.Forms.TextBox leftimgpath;
        private System.Windows.Forms.Button rightselectbtn;
        internal System.Windows.Forms.TextBox rightimgpath;
        private System.Windows.Forms.Button intselectbtn;
        internal System.Windows.Forms.TextBox intimgpath;
        internal System.Windows.Forms.NumericUpDown numwidth;
        internal System.Windows.Forms.NumericUpDown numspeedC;
        internal System.Windows.Forms.NumericUpDown numspeedO;
        internal System.Windows.Forms.NumericUpDown numspxC;
        internal System.Windows.Forms.NumericUpDown numspxO;
        internal System.Windows.Forms.NumericUpDown numpositionC;
        internal System.Windows.Forms.NumericUpDown numpositionO;
        internal System.Windows.Forms.NumericUpDown numratioC;
        internal System.Windows.Forms.NumericUpDown numratioO;
        internal System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSettingToolStripMenuItem;
        internal System.Windows.Forms.BindingSource XML_BindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}