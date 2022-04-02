namespace WindowsBindingNavigator
{
    partial class BindingNavigator_Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindingNavigator_Form));
            this.XML_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.XML_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Category_GroupBox = new System.Windows.Forms.GroupBox();
            this.Oracle_CheckBox = new System.Windows.Forms.CheckBox();
            this.VB_CheckBox = new System.Windows.Forms.CheckBox();
            this.URL_TextBox = new System.Windows.Forms.TextBox();
            this.URL_Label = new System.Windows.Forms.Label();
            this.Title_TextBox = new System.Windows.Forms.TextBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.Date_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XML_BindingNavigator)).BeginInit();
            this.XML_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XML_BindingSource)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.Category_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // XML_BindingNavigator
            // 
            this.XML_BindingNavigator.AddNewItem = this.BindingNavigatorAddNewItem;
            this.XML_BindingNavigator.BindingSource = this.XML_BindingSource;
            this.XML_BindingNavigator.CountItem = this.BindingNavigatorCountItem;
            this.XML_BindingNavigator.DeleteItem = this.BindingNavigatorDeleteItem;
            this.XML_BindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.XML_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.BindingNavigatorAddNewItem,
            this.BindingNavigatorDeleteItem});
            this.XML_BindingNavigator.Location = new System.Drawing.Point(0, 178);
            this.XML_BindingNavigator.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.XML_BindingNavigator.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.XML_BindingNavigator.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.XML_BindingNavigator.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.XML_BindingNavigator.Name = "XML_BindingNavigator";
            this.XML_BindingNavigator.PositionItem = this.BindingNavigatorPositionItem;
            this.XML_BindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.XML_BindingNavigator.TabIndex = 8;
            this.XML_BindingNavigator.Text = "BindingNavigator1";
            // 
            // BindingNavigatorAddNewItem
            // 
            this.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorAddNewItem.Image")));
            this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.BindingNavigatorCountItem.Text = "/ {0}";
            this.BindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorDeleteItem.Image")));
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorDeleteItem.Text = "削除";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "位置";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(284, 26);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenToolStripMenuItem,
            this.FileSaveToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.FileExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.FileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // FileOpenToolStripMenuItem
            // 
            this.FileOpenToolStripMenuItem.Name = "FileOpenToolStripMenuItem";
            this.FileOpenToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.FileOpenToolStripMenuItem.Text = "開く(&O)";
            this.FileOpenToolStripMenuItem.Click += new System.EventHandler(this.FileOpenToolStripMenuItem_Click);
            // 
            // FileSaveToolStripMenuItem
            // 
            this.FileSaveToolStripMenuItem.Enabled = false;
            this.FileSaveToolStripMenuItem.Name = "FileSaveToolStripMenuItem";
            this.FileSaveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.FileSaveToolStripMenuItem.Text = "保存(&S)";
            this.FileSaveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // FileExitToolStripMenuItem
            // 
            this.FileExitToolStripMenuItem.Name = "FileExitToolStripMenuItem";
            this.FileExitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.FileExitToolStripMenuItem.Text = "終了(&X)";
            this.FileExitToolStripMenuItem.Click += new System.EventHandler(this.FileExitToolStripMenuItem_Click);
            // 
            // Category_GroupBox
            // 
            this.Category_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Category_GroupBox.Controls.Add(this.Oracle_CheckBox);
            this.Category_GroupBox.Controls.Add(this.VB_CheckBox);
            this.Category_GroupBox.Location = new System.Drawing.Point(12, 104);
            this.Category_GroupBox.Name = "Category_GroupBox";
            this.Category_GroupBox.Size = new System.Drawing.Size(260, 63);
            this.Category_GroupBox.TabIndex = 7;
            this.Category_GroupBox.TabStop = false;
            this.Category_GroupBox.Text = "カテゴリ";
            // 
            // Oracle_CheckBox
            // 
            this.Oracle_CheckBox.AutoSize = true;
            this.Oracle_CheckBox.Location = new System.Drawing.Point(48, 40);
            this.Oracle_CheckBox.Name = "Oracle_CheckBox";
            this.Oracle_CheckBox.Size = new System.Drawing.Size(109, 16);
            this.Oracle_CheckBox.TabIndex = 1;
            this.Oracle_CheckBox.Text = "Oracle Database";
            this.Oracle_CheckBox.UseVisualStyleBackColor = true;
            // 
            // VB_CheckBox
            // 
            this.VB_CheckBox.AutoSize = true;
            this.VB_CheckBox.Location = new System.Drawing.Point(48, 18);
            this.VB_CheckBox.Name = "VB_CheckBox";
            this.VB_CheckBox.Size = new System.Drawing.Size(89, 16);
            this.VB_CheckBox.TabIndex = 0;
            this.VB_CheckBox.Text = "Visual Basic";
            this.VB_CheckBox.UseVisualStyleBackColor = true;
            // 
            // URL_TextBox
            // 
            this.URL_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.URL_TextBox.Location = new System.Drawing.Point(60, 79);
            this.URL_TextBox.Name = "URL_TextBox";
            this.URL_TextBox.Size = new System.Drawing.Size(212, 19);
            this.URL_TextBox.TabIndex = 6;
            // 
            // URL_Label
            // 
            this.URL_Label.AutoSize = true;
            this.URL_Label.Location = new System.Drawing.Point(12, 82);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(29, 12);
            this.URL_Label.TabIndex = 5;
            this.URL_Label.Text = "URL:";
            // 
            // Title_TextBox
            // 
            this.Title_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_TextBox.Location = new System.Drawing.Point(60, 54);
            this.Title_TextBox.Name = "Title_TextBox";
            this.Title_TextBox.Size = new System.Drawing.Size(212, 19);
            this.Title_TextBox.TabIndex = 4;
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Location = new System.Drawing.Point(12, 57);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(42, 12);
            this.Title_Label.TabIndex = 3;
            this.Title_Label.Text = "タイトル:";
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_TextBox.Location = new System.Drawing.Point(60, 29);
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(212, 19);
            this.Date_TextBox.TabIndex = 2;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(12, 32);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(31, 12);
            this.Date_Label.TabIndex = 1;
            this.Date_Label.Text = "日付:";
            // 
            // BindingNavigator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.Category_GroupBox);
            this.Controls.Add(this.URL_TextBox);
            this.Controls.Add(this.URL_Label);
            this.Controls.Add(this.Title_TextBox);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Date_TextBox);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.XML_BindingNavigator);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BindingNavigator_Form";
            this.Text = "BindingNavigatorCs";
            ((System.ComponentModel.ISupportInitialize)(this.XML_BindingNavigator)).EndInit();
            this.XML_BindingNavigator.ResumeLayout(false);
            this.XML_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XML_BindingSource)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.Category_GroupBox.ResumeLayout(false);
            this.Category_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.BindingSource XML_BindingSource;
        internal System.Windows.Forms.BindingNavigator XML_BindingNavigator;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorAddNewItem;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorDeleteItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FileOpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FileSaveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem FileExitToolStripMenuItem;
        internal System.Windows.Forms.GroupBox Category_GroupBox;
        internal System.Windows.Forms.CheckBox Oracle_CheckBox;
        internal System.Windows.Forms.CheckBox VB_CheckBox;
        internal System.Windows.Forms.TextBox URL_TextBox;
        internal System.Windows.Forms.Label URL_Label;
        internal System.Windows.Forms.TextBox Title_TextBox;
        internal System.Windows.Forms.Label Title_Label;
        internal System.Windows.Forms.TextBox Date_TextBox;
        internal System.Windows.Forms.Label Date_Label;
    }
}

