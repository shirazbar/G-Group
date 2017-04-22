namespace News
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MTV = new System.Windows.Forms.PictureBox();
            this.NY = new System.Windows.Forms.PictureBox();
            this.ABC = new System.Windows.Forms.PictureBox();
            this.BBC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ABC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBC)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::News.Properties.Resources.news;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // MTV
            // 
            this.MTV.Image = global::News.Properties.Resources.mtv;
            this.MTV.Location = new System.Drawing.Point(291, 250);
            this.MTV.Name = "MTV";
            this.MTV.Size = new System.Drawing.Size(126, 97);
            this.MTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MTV.TabIndex = 3;
            this.MTV.TabStop = false;
            this.MTV.Click += new System.EventHandler(this.MTV_Click);
            // 
            // NY
            // 
            this.NY.Image = global::News.Properties.Resources.NYT;
            this.NY.Location = new System.Drawing.Point(56, 250);
            this.NY.Name = "NY";
            this.NY.Size = new System.Drawing.Size(132, 97);
            this.NY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NY.TabIndex = 2;
            this.NY.TabStop = false;
            this.NY.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ABC
            // 
            this.ABC.Image = global::News.Properties.Resources.abc;
            this.ABC.Location = new System.Drawing.Point(291, 143);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(126, 91);
            this.ABC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ABC.TabIndex = 1;
            this.ABC.TabStop = false;
            this.ABC.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BBC
            // 
            this.BBC.Image = global::News.Properties.Resources.bbc_world_news;
            this.BBC.Location = new System.Drawing.Point(56, 143);
            this.BBC.Name = "BBC";
            this.BBC.Size = new System.Drawing.Size(132, 91);
            this.BBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BBC.TabIndex = 0;
            this.BBC.TabStop = false;
            this.BBC.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MTV);
            this.Controls.Add(this.NY);
            this.Controls.Add(this.ABC);
            this.Controls.Add(this.BBC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ABC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BBC;
        private System.Windows.Forms.PictureBox ABC;
        private System.Windows.Forms.PictureBox NY;
        private System.Windows.Forms.PictureBox MTV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

