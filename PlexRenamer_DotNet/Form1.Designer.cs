namespace PlexRenamer_DotNet
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
            this.label1 = new System.Windows.Forms.Label();
            this.DirectforyFinder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnChooseDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.numupSeason = new System.Windows.Forms.NumericUpDown();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.listData = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numupSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(135, 31);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 25);
            this.lblPath.TabIndex = 1;
            // 
            // btnChooseDirectory
            // 
            this.btnChooseDirectory.Location = new System.Drawing.Point(18, 69);
            this.btnChooseDirectory.Name = "btnChooseDirectory";
            this.btnChooseDirectory.Size = new System.Drawing.Size(187, 23);
            this.btnChooseDirectory.TabIndex = 2;
            this.btnChooseDirectory.Text = "Pick Directory";
            this.btnChooseDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Season:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Show:";
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(67, 114);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(138, 20);
            this.txtShow.TabIndex = 5;
            // 
            // numupSeason
            // 
            this.numupSeason.Location = new System.Drawing.Point(67, 157);
            this.numupSeason.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupSeason.Name = "numupSeason";
            this.numupSeason.Size = new System.Drawing.Size(50, 20);
            this.numupSeason.TabIndex = 6;
            this.numupSeason.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(18, 228);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(18, 199);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // listData
            // 
            this.listData.Location = new System.Drawing.Point(245, 69);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(550, 376);
            this.listData.TabIndex = 9;
            this.listData.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.numupSeason);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseDirectory);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Plex Renamer Dotnet 1.0.6 Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FolderBrowserDialog DirectforyFinder;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnChooseDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.NumericUpDown numupSeason;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListView listData;
    }
}

