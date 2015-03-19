namespace PictureSelect
{
    partial class VersionDialog
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionDialog));
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkMail = new System.Windows.Forms.LinkLabel();
            this.linkHP = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(71, 12);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(73, 12);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "PictureSelect";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(71, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(35, 12);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "0.9.0.1";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(71, 54);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(222, 12);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright © Seiji HAMAGUCHI 2011-2015";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(71, 75);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(99, 12);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "Seiji HAMAGUCHI";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.CausesValidation = false;
            this.textBoxDescription.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxDescription.Location = new System.Drawing.Point(12, 146);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(362, 215);
            this.textBoxDescription.TabIndex = 4;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(299, 367);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 27);
            this.exit.TabIndex = 5;
            this.exit.Text = "OK";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // linkMail
            // 
            this.linkMail.AutoSize = true;
            this.linkMail.Location = new System.Drawing.Point(81, 97);
            this.linkMail.Name = "linkMail";
            this.linkMail.Size = new System.Drawing.Size(98, 12);
            this.linkMail.TabIndex = 7;
            this.linkMail.TabStop = true;
            this.linkMail.Text = "makoto@dive-in.to";
            this.linkMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMail_LinkClicked);
            // 
            // linkHP
            // 
            this.linkHP.AutoSize = true;
            this.linkHP.Location = new System.Drawing.Point(81, 120);
            this.linkHP.Name = "linkHP";
            this.linkHP.Size = new System.Drawing.Size(152, 12);
            this.linkHP.TabIndex = 8;
            this.linkHP.TabStop = true;
            this.linkHP.Text = "http://hamaguchi.yokohama/";
            this.linkHP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHP_LinkClicked);
            // 
            // VersionDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 404);
            this.Controls.Add(this.linkHP);
            this.Controls.Add(this.linkMail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkMail;
        private System.Windows.Forms.LinkLabel linkHP;


    }
}
