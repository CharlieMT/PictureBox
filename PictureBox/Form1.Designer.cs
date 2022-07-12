
using System.Windows.Forms;

namespace PictureBox
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pbMainPicture = new System.Windows.Forms.PictureBox();
            this.btPrevious = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbxImageViewre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageViewre)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainPicture
            // 
            this.pbMainPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMainPicture.BackColor = System.Drawing.Color.DarkGray;
            this.pbMainPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMainPicture.BackgroundImage")));
            this.pbMainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMainPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMainPicture.Location = new System.Drawing.Point(9, 9);
            this.pbMainPicture.Margin = new System.Windows.Forms.Padding(0);
            this.pbMainPicture.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.pbMainPicture.MinimumSize = new System.Drawing.Size(400, 400);
            this.pbMainPicture.Name = "pbMainPicture";
            this.pbMainPicture.Size = new System.Drawing.Size(1166, 706);
            this.pbMainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPicture.TabIndex = 0;
            this.pbMainPicture.TabStop = false;
            // 
            // btPrevious
            // 
            this.btPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPrevious.FlatAppearance.BorderSize = 0;
            this.btPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPrevious.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btPrevious.Location = new System.Drawing.Point(0, 0);
            this.btPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btPrevious.MinimumSize = new System.Drawing.Size(80, 80);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(350, 706);
            this.btPrevious.TabIndex = 1;
            this.btPrevious.Text = "<";
            this.btPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPrevious.UseVisualStyleBackColor = false;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.BackColor = System.Drawing.Color.Transparent;
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btNext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btNext.Location = new System.Drawing.Point(828, 0);
            this.btNext.Margin = new System.Windows.Forms.Padding(0);
            this.btNext.MinimumSize = new System.Drawing.Size(80, 80);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(350, 706);
            this.btNext.TabIndex = 2;
            this.btNext.Text = ">";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbxImageViewre
            // 
            this.pbxImageViewre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImageViewre.BackColor = System.Drawing.Color.Transparent;
            this.pbxImageViewre.Location = new System.Drawing.Point(400, 732);
            this.pbxImageViewre.Margin = new System.Windows.Forms.Padding(0);
            this.pbxImageViewre.MaximumSize = new System.Drawing.Size(1600, 120);
            this.pbxImageViewre.MinimumSize = new System.Drawing.Size(300, 60);
            this.pbxImageViewre.Name = "pbxImageViewre";
            this.pbxImageViewre.Size = new System.Drawing.Size(360, 120);
            this.pbxImageViewre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageViewre.TabIndex = 3;
            this.pbxImageViewre.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.pbxImageViewre);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.pbMainPicture);
            this.MaximumSize = new System.Drawing.Size(1920, 1180);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageViewre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainPicture;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbxImageViewre;
    }
}

