
namespace WiXGeneraterSnippets
{
    partial class FrmMain
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkCustomSource = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyPath = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDirectoryBg = new System.Windows.Forms.TextBox();
            this.btnGenerateBg = new System.Windows.Forms.Button();
            this.chkCustomSourceBg = new System.Windows.Forms.CheckBox();
            this.txtOutputBg = new System.Windows.Forms.TextBox();
            this.btnBrowseBg = new System.Windows.Forms.Button();
            this.txtDirectoryVid = new System.Windows.Forms.TextBox();
            this.btnGenerateVid = new System.Windows.Forms.Button();
            this.chkCustomSourceVid = new System.Windows.Forms.CheckBox();
            this.txtOutputVid = new System.Windows.Forms.TextBox();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDirectory);
            this.tabPage1.Controls.Add(this.checkBoxKeyPath);
            this.tabPage1.Controls.Add(this.btnGenerate);
            this.tabPage1.Controls.Add(this.chkCustomSource);
            this.tabPage1.Controls.Add(this.txtOutput);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Songs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 419);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDirectoryBg);
            this.tabPage2.Controls.Add(this.btnGenerateBg);
            this.tabPage2.Controls.Add(this.chkCustomSourceBg);
            this.tabPage2.Controls.Add(this.txtOutputBg);
            this.tabPage2.Controls.Add(this.btnBrowseBg);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Background";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 49);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(87, 35);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(6, 6);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(663, 25);
            this.txtDirectory.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(6, 90);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(756, 293);
            this.txtOutput.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(675, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(87, 25);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkCustomSource
            // 
            this.chkCustomSource.AutoSize = true;
            this.chkCustomSource.Location = new System.Drawing.Point(99, 59);
            this.chkCustomSource.Name = "chkCustomSource";
            this.chkCustomSource.Size = new System.Drawing.Size(147, 21);
            this.chkCustomSource.TabIndex = 4;
            this.chkCustomSource.Text = "Source by Directory";
            this.chkCustomSource.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeyPath
            // 
            this.checkBoxKeyPath.AutoSize = true;
            this.checkBoxKeyPath.Location = new System.Drawing.Point(252, 57);
            this.checkBoxKeyPath.Name = "checkBoxKeyPath";
            this.checkBoxKeyPath.Size = new System.Drawing.Size(131, 21);
            this.checkBoxKeyPath.TabIndex = 5;
            this.checkBoxKeyPath.Text = "Copy to All Users";
            this.checkBoxKeyPath.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDirectoryVid);
            this.tabPage3.Controls.Add(this.btnGenerateVid);
            this.tabPage3.Controls.Add(this.chkCustomSourceVid);
            this.tabPage3.Controls.Add(this.txtOutputVid);
            this.tabPage3.Controls.Add(this.btnBrowseVideo);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Video";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDirectoryBg
            // 
            this.txtDirectoryBg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectoryBg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectoryBg.Location = new System.Drawing.Point(6, 6);
            this.txtDirectoryBg.Name = "txtDirectoryBg";
            this.txtDirectoryBg.Size = new System.Drawing.Size(663, 25);
            this.txtDirectoryBg.TabIndex = 6;
            // 
            // btnGenerateBg
            // 
            this.btnGenerateBg.Location = new System.Drawing.Point(6, 49);
            this.btnGenerateBg.Name = "btnGenerateBg";
            this.btnGenerateBg.Size = new System.Drawing.Size(87, 35);
            this.btnGenerateBg.TabIndex = 5;
            this.btnGenerateBg.Text = "Generate";
            this.btnGenerateBg.UseVisualStyleBackColor = true;
            this.btnGenerateBg.Click += new System.EventHandler(this.btnGenerateBg_Click);
            // 
            // chkCustomSourceBg
            // 
            this.chkCustomSourceBg.AutoSize = true;
            this.chkCustomSourceBg.Location = new System.Drawing.Point(99, 59);
            this.chkCustomSourceBg.Name = "chkCustomSourceBg";
            this.chkCustomSourceBg.Size = new System.Drawing.Size(147, 21);
            this.chkCustomSourceBg.TabIndex = 9;
            this.chkCustomSourceBg.Text = "Source by Directory";
            this.chkCustomSourceBg.UseVisualStyleBackColor = true;
            // 
            // txtOutputBg
            // 
            this.txtOutputBg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputBg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputBg.Location = new System.Drawing.Point(6, 90);
            this.txtOutputBg.Multiline = true;
            this.txtOutputBg.Name = "txtOutputBg";
            this.txtOutputBg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputBg.Size = new System.Drawing.Size(756, 293);
            this.txtOutputBg.TabIndex = 7;
            // 
            // btnBrowseBg
            // 
            this.btnBrowseBg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseBg.Location = new System.Drawing.Point(675, 6);
            this.btnBrowseBg.Name = "btnBrowseBg";
            this.btnBrowseBg.Size = new System.Drawing.Size(87, 25);
            this.btnBrowseBg.TabIndex = 8;
            this.btnBrowseBg.Text = "Browse";
            this.btnBrowseBg.UseVisualStyleBackColor = true;
            this.btnBrowseBg.Click += new System.EventHandler(this.btnBrowseBg_Click);
            // 
            // txtDirectoryVid
            // 
            this.txtDirectoryVid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectoryVid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectoryVid.Location = new System.Drawing.Point(6, 6);
            this.txtDirectoryVid.Name = "txtDirectoryVid";
            this.txtDirectoryVid.Size = new System.Drawing.Size(663, 25);
            this.txtDirectoryVid.TabIndex = 6;
            // 
            // btnGenerateVid
            // 
            this.btnGenerateVid.Location = new System.Drawing.Point(6, 49);
            this.btnGenerateVid.Name = "btnGenerateVid";
            this.btnGenerateVid.Size = new System.Drawing.Size(87, 35);
            this.btnGenerateVid.TabIndex = 5;
            this.btnGenerateVid.Text = "Generate";
            this.btnGenerateVid.UseVisualStyleBackColor = true;
            this.btnGenerateVid.Click += new System.EventHandler(this.btnGenerateVid_Click);
            // 
            // chkCustomSourceVid
            // 
            this.chkCustomSourceVid.AutoSize = true;
            this.chkCustomSourceVid.Location = new System.Drawing.Point(99, 59);
            this.chkCustomSourceVid.Name = "chkCustomSourceVid";
            this.chkCustomSourceVid.Size = new System.Drawing.Size(147, 21);
            this.chkCustomSourceVid.TabIndex = 9;
            this.chkCustomSourceVid.Text = "Source by Directory";
            this.chkCustomSourceVid.UseVisualStyleBackColor = true;
            // 
            // txtOutputVid
            // 
            this.txtOutputVid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputVid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputVid.Location = new System.Drawing.Point(6, 90);
            this.txtOutputVid.Multiline = true;
            this.txtOutputVid.Name = "txtOutputVid";
            this.txtOutputVid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputVid.Size = new System.Drawing.Size(756, 293);
            this.txtOutputVid.TabIndex = 7;
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseVideo.Location = new System.Drawing.Point(675, 6);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(87, 25);
            this.btnBrowseVideo.TabIndex = 8;
            this.btnBrowseVideo.Text = "Browse";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snippets Generator for WiX";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkCustomSource;
        private System.Windows.Forms.CheckBox checkBoxKeyPath;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtDirectoryBg;
        private System.Windows.Forms.Button btnGenerateBg;
        private System.Windows.Forms.CheckBox chkCustomSourceBg;
        private System.Windows.Forms.TextBox txtOutputBg;
        private System.Windows.Forms.Button btnBrowseBg;
        private System.Windows.Forms.TextBox txtDirectoryVid;
        private System.Windows.Forms.Button btnGenerateVid;
        private System.Windows.Forms.CheckBox chkCustomSourceVid;
        private System.Windows.Forms.TextBox txtOutputVid;
        private System.Windows.Forms.Button btnBrowseVideo;
    }
}

