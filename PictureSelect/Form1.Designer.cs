namespace PictureSelect
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pictureFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.deleteStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureDelete = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.second3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.second5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.second8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectEXIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableEXIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableEXIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDelete = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.pictureFilePath,
            this.deleteStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // pictureFilePath
            // 
            this.pictureFilePath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pictureFilePath.Name = "pictureFilePath";
            this.pictureFilePath.Size = new System.Drawing.Size(0, 17);
            // 
            // deleteStatusLabel
            // 
            this.deleteStatusLabel.Name = "deleteStatusLabel";
            this.deleteStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureDelete
            // 
            this.pictureDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pictureDelete.Name = "pictureDelete";
            this.pictureDelete.Size = new System.Drawing.Size(0, 17);
            this.pictureDelete.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDirectoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.fileToolStripMenuItem.Text = "ファイル(F)";
            // 
            // selectDirectoryToolStripMenuItem
            // 
            this.selectDirectoryToolStripMenuItem.Name = "selectDirectoryToolStripMenuItem";
            this.selectDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.selectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.selectDirectoryToolStripMenuItem.Text = "取得ディレクトリ設定(O)";
            this.selectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.selectDirectoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.exitToolStripMenuItem.Text = "終了(X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editPictureToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.editToolStripMenuItem.Text = "編集(E)";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.deleteToolStripMenuItem.Text = "削除(D)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editPictureToolStripMenuItem
            // 
            this.editPictureToolStripMenuItem.Name = "editPictureToolStripMenuItem";
            this.editPictureToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.editPictureToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.editPictureToolStripMenuItem.Text = "関連プログラム起動(X)";
            this.editPictureToolStripMenuItem.Click += new System.EventHandler(this.editPictureToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem1,
            this.autoPlayToolStripMenuItem,
            this.selectEXIFToolStripMenuItem,
            this.editProgramToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.toolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.toolToolStripMenuItem.Text = "設定(T)";
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.backToolStripMenuItem1.Text = "バックカラー(B)";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // autoPlayToolStripMenuItem
            // 
            this.autoPlayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noSecondToolStripMenuItem,
            this.second3ToolStripMenuItem,
            this.second5ToolStripMenuItem,
            this.second8ToolStripMenuItem});
            this.autoPlayToolStripMenuItem.Name = "autoPlayToolStripMenuItem";
            this.autoPlayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.autoPlayToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.autoPlayToolStripMenuItem.Text = "自動再生(S)";
            // 
            // noSecondToolStripMenuItem
            // 
            this.noSecondToolStripMenuItem.CheckOnClick = true;
            this.noSecondToolStripMenuItem.Name = "noSecondToolStripMenuItem";
            this.noSecondToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.noSecondToolStripMenuItem.Text = "自動再生しない";
            this.noSecondToolStripMenuItem.Click += new System.EventHandler(this.noSecondToolStripMenuItem_Click);
            // 
            // second3ToolStripMenuItem
            // 
            this.second3ToolStripMenuItem.CheckOnClick = true;
            this.second3ToolStripMenuItem.Name = "second3ToolStripMenuItem";
            this.second3ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.second3ToolStripMenuItem.Text = "3秒";
            this.second3ToolStripMenuItem.Click += new System.EventHandler(this.second3ToolStripMenuItem_Click);
            // 
            // second5ToolStripMenuItem
            // 
            this.second5ToolStripMenuItem.CheckOnClick = true;
            this.second5ToolStripMenuItem.Name = "second5ToolStripMenuItem";
            this.second5ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.second5ToolStripMenuItem.Text = "5秒";
            this.second5ToolStripMenuItem.Click += new System.EventHandler(this.second5ToolStripMenuItem_Click);
            // 
            // second8ToolStripMenuItem
            // 
            this.second8ToolStripMenuItem.CheckOnClick = true;
            this.second8ToolStripMenuItem.Name = "second8ToolStripMenuItem";
            this.second8ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.second8ToolStripMenuItem.Text = "8秒";
            this.second8ToolStripMenuItem.Click += new System.EventHandler(this.second8ToolStripMenuItem_Click);
            // 
            // selectEXIFToolStripMenuItem
            // 
            this.selectEXIFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableEXIFToolStripMenuItem,
            this.enableEXIFToolStripMenuItem});
            this.selectEXIFToolStripMenuItem.Name = "selectEXIFToolStripMenuItem";
            this.selectEXIFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.selectEXIFToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.selectEXIFToolStripMenuItem.Text = "EXIF表示(I)";
            // 
            // disableEXIFToolStripMenuItem
            // 
            this.disableEXIFToolStripMenuItem.CheckOnClick = true;
            this.disableEXIFToolStripMenuItem.Name = "disableEXIFToolStripMenuItem";
            this.disableEXIFToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.disableEXIFToolStripMenuItem.Text = "表示なし";
            this.disableEXIFToolStripMenuItem.Click += new System.EventHandler(this.disableEXIFToolStripMenuItem_Click);
            // 
            // enableEXIFToolStripMenuItem
            // 
            this.enableEXIFToolStripMenuItem.CheckOnClick = true;
            this.enableEXIFToolStripMenuItem.Name = "enableEXIFToolStripMenuItem";
            this.enableEXIFToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.enableEXIFToolStripMenuItem.Text = "表示あり";
            this.enableEXIFToolStripMenuItem.Click += new System.EventHandler(this.enableEXIFToolStripMenuItem_Click);
            // 
            // editProgramToolStripMenuItem
            // 
            this.editProgramToolStripMenuItem.Name = "editProgramToolStripMenuItem";
            this.editProgramToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.editProgramToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.helpToolStripMenuItem.Text = "ヘルプ(H)";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(312, 22);
            this.helpToolStripMenuItem1.Text = "機能説明(P)";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.versionToolStripMenuItem.Text = "PictureSelect のバージョン情報(A)";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelDelete);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 394);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(429, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(195, 394);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "フィールド";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "データ";
            this.Column2.Name = "Column2";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDelete.ForeColor = System.Drawing.Color.Red;
            this.labelDelete.Location = new System.Drawing.Point(10, 10);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(0, 12);
            this.labelDelete.TabIndex = 2;
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 394);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureMain
            // 
            this.pictureMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureMain.Location = new System.Drawing.Point(0, 0);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(624, 394);
            this.pictureMain.TabIndex = 0;
            this.pictureMain.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(624, 394);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(624, 442);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PictureSelect";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureMain;
        private System.Windows.Forms.ToolStripMenuItem selectDirectoryToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel pictureFilePath;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel pictureDelete;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ToolStripMenuItem autoPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem second3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem second5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem second8ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem noSecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectEXIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableEXIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableEXIFToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripStatusLabel deleteStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem editProgramToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem editPictureToolStripMenuItem;
    }
}

