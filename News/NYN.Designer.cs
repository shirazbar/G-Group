namespace News
{
    partial class NYN
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
            this.NY = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NY)).BeginInit();
            this.SuspendLayout();
            // 
            // NY
            // 
            this.NY.Image = global::News.Properties.Resources.NYT;
            this.NY.Location = new System.Drawing.Point(128, 12);
            this.NY.Name = "NY";
            this.NY.Size = new System.Drawing.Size(132, 97);
            this.NY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NY.TabIndex = 3;
            this.NY.TabStop = false;
            // 
            // NYN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 336);
            this.Controls.Add(this.NY);
            this.Name = "NYN";
            this.Text = "NYN";
            this.Load += new System.EventHandler(this.NYN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NY;
    }
}