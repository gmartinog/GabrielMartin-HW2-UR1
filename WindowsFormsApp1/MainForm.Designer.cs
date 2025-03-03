namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxThreshold = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(24, 23);
            this.picture1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(748, 825);
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // pictureBoxThreshold
            // 
            this.pictureBoxThreshold.Location = new System.Drawing.Point(842, 23);
            this.pictureBoxThreshold.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxThreshold.Name = "pictureBoxThreshold";
            this.pictureBoxThreshold.Size = new System.Drawing.Size(664, 825);
            this.pictureBoxThreshold.TabIndex = 1;
            this.pictureBoxThreshold.TabStop = false;
            this.pictureBoxThreshold.Click += new System.EventHandler(this.pictureBoxThreshold_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.pictureBoxThreshold);
            this.Controls.Add(this.picture1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox pictureBoxThreshold;
    }
}