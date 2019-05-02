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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.chkSubtitles = new System.Windows.Forms.CheckBox();
            this.txtSubtitles = new System.Windows.Forms.TextBox();
            this.lblSubtitles = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProgramDone = new System.Windows.Forms.Label();
            this.chkDifEp = new System.Windows.Forms.CheckBox();
            this.numStartingCount = new System.Windows.Forms.NumericUpDown();
            this.lblStartCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numupSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartingCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(180, 38);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 31);
            this.lblPath.TabIndex = 1;
            // 
            // btnChooseDirectory
            // 
            this.btnChooseDirectory.Location = new System.Drawing.Point(24, 86);
            this.btnChooseDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseDirectory.Name = "btnChooseDirectory";
            this.btnChooseDirectory.Size = new System.Drawing.Size(249, 28);
            this.btnChooseDirectory.TabIndex = 2;
            this.btnChooseDirectory.Text = "Pick Directory";
            this.btnChooseDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Season:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Show:";
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(89, 140);
            this.txtShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(183, 22);
            this.txtShow.TabIndex = 5;
            // 
            // numupSeason
            // 
            this.numupSeason.Location = new System.Drawing.Point(89, 193);
            this.numupSeason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numupSeason.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupSeason.Name = "numupSeason";
            this.numupSeason.Size = new System.Drawing.Size(67, 22);
            this.numupSeason.TabIndex = 6;
            this.numupSeason.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(24, 295);
            this.btnRename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(100, 28);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(24, 260);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // chkSubtitles
            // 
            this.chkSubtitles.AutoSize = true;
            this.chkSubtitles.Location = new System.Drawing.Point(167, 197);
            this.chkSubtitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSubtitles.Name = "chkSubtitles";
            this.chkSubtitles.Size = new System.Drawing.Size(114, 21);
            this.chkSubtitles.TabIndex = 10;
            this.chkSubtitles.Text = "Subtitle files?";
            this.chkSubtitles.UseVisualStyleBackColor = true;
            this.chkSubtitles.CheckedChanged += new System.EventHandler(this.chkSubtitles_CheckedChanged);
            // 
            // txtSubtitles
            // 
            this.txtSubtitles.Location = new System.Drawing.Point(187, 260);
            this.txtSubtitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtitles.Name = "txtSubtitles";
            this.txtSubtitles.Size = new System.Drawing.Size(59, 22);
            this.txtSubtitles.TabIndex = 11;
            this.txtSubtitles.Visible = false;
            // 
            // lblSubtitles
            // 
            this.lblSubtitles.AutoSize = true;
            this.lblSubtitles.Location = new System.Drawing.Point(85, 240);
            this.lblSubtitles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitles.Name = "lblSubtitles";
            this.lblSubtitles.Size = new System.Drawing.Size(236, 17);
            this.lblSubtitles.TabIndex = 12;
            this.lblSubtitles.Text = "Language 3 letters (Default English)";
            this.lblSubtitles.Visible = false;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Location = new System.Drawing.Point(319, 85);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(712, 463);
            this.dgvData.TabIndex = 13;
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePath.HeaderText = "File Path";
            this.FilePath.Name = "FilePath";
            // 
            // lblProgramDone
            // 
            this.lblProgramDone.AutoSize = true;
            this.lblProgramDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramDone.ForeColor = System.Drawing.Color.Black;
            this.lblProgramDone.Location = new System.Drawing.Point(160, 295);
            this.lblProgramDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgramDone.Name = "lblProgramDone";
            this.lblProgramDone.Size = new System.Drawing.Size(0, 31);
            this.lblProgramDone.TabIndex = 14;
            // 
            // chkDifEp
            // 
            this.chkDifEp.AutoSize = true;
            this.chkDifEp.Location = new System.Drawing.Point(24, 345);
            this.chkDifEp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDifEp.Name = "chkDifEp";
            this.chkDifEp.Size = new System.Drawing.Size(241, 21);
            this.chkDifEp.TabIndex = 15;
            this.chkDifEp.Text = "Start count from differnt episode?";
            this.chkDifEp.UseVisualStyleBackColor = true;
            this.chkDifEp.CheckedChanged += new System.EventHandler(this.chkDifEp_CheckedChanged);
            // 
            // numStartingCount
            // 
            this.numStartingCount.Location = new System.Drawing.Point(167, 373);
            this.numStartingCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numStartingCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numStartingCount.Name = "numStartingCount";
            this.numStartingCount.Size = new System.Drawing.Size(57, 22);
            this.numStartingCount.TabIndex = 16;
            this.numStartingCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartingCount.Visible = false;
            // 
            // lblStartCount
            // 
            this.lblStartCount.AutoSize = true;
            this.lblStartCount.Location = new System.Drawing.Point(47, 375);
            this.lblStartCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartCount.Name = "lblStartCount";
            this.lblStartCount.Size = new System.Drawing.Size(96, 17);
            this.lblStartCount.TabIndex = 17;
            this.lblStartCount.Text = "Starting count";
            this.lblStartCount.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblStartCount);
            this.Controls.Add(this.numStartingCount);
            this.Controls.Add(this.chkDifEp);
            this.Controls.Add(this.lblProgramDone);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblSubtitles);
            this.Controls.Add(this.txtSubtitles);
            this.Controls.Add(this.chkSubtitles);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.numupSeason);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseDirectory);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Plex Renamer Dotnet 1.1.10 Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartingCount)).EndInit();
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
        private System.Windows.Forms.CheckBox chkSubtitles;
        private System.Windows.Forms.TextBox txtSubtitles;
        private System.Windows.Forms.Label lblSubtitles;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblProgramDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.CheckBox chkDifEp;
        private System.Windows.Forms.NumericUpDown numStartingCount;
        private System.Windows.Forms.Label lblStartCount;
    }
}

