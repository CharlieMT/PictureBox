
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
            this.pbMainPicture = new System.Windows.Forms.PictureBox();
            this.btPrevious = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainPicture
            // 
            this.pbMainPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMainPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbMainPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMainPicture.Location = new System.Drawing.Point(196, 39);
            this.pbMainPicture.Margin = new System.Windows.Forms.Padding(0);
            this.pbMainPicture.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.pbMainPicture.MinimumSize = new System.Drawing.Size(400, 300);
            this.pbMainPicture.Name = "pbMainPicture";
            this.pbMainPicture.Size = new System.Drawing.Size(832, 661);
            this.pbMainPicture.TabIndex = 0;
            this.pbMainPicture.TabStop = false;
            // 
            // btPrevious
            // 
            this.btPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btPrevious.AutoSize = true;
            this.btPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPrevious.FlatAppearance.BorderSize = 0;
            this.btPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPrevious.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btPrevious.Location = new System.Drawing.Point(40, 230);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(130, 230);
            this.btPrevious.TabIndex = 1;
            this.btPrevious.Text = "<";
            this.btPrevious.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btNext.AutoSize = true;
            this.btNext.BackColor = System.Drawing.Color.Transparent;
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btNext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btNext.Location = new System.Drawing.Point(1050, 230);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(130, 230);
            this.btNext.TabIndex = 2;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 744);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1140, 113);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1216, 922);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.pbMainPicture);
            this.MaximumSize = new System.Drawing.Size(1920, 1180);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainPicture;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

