namespace Exchange_Rates
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
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display_txt = new System.Windows.Forms.Label();
            this.conv_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amount_txt
            // 
            this.amount_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_txt.Location = new System.Drawing.Point(113, 32);
            this.amount_txt.Multiline = true;
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(152, 34);
            this.amount_txt.TabIndex = 0;
            // 
            // comboFrom
            // 
            this.comboFrom.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Items.AddRange(new object[] {
            "ILS-Israeli Shekel",
            "EUR-Euro",
            "USD-US Dollar",
            "GBP-British Pound",
            "JPY-Japanise Yen"});
            this.comboFrom.Location = new System.Drawing.Point(113, 96);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(152, 27);
            this.comboFrom.TabIndex = 1;
            // 
            // comboTo
            // 
            this.comboTo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Items.AddRange(new object[] {
            "ILS-Israeli Shekel",
            "EUR-Euro",
            "USD-US Dollar",
            "GBP-British Pound",
            "JPY-Japanise Yen"});
            this.comboTo.Location = new System.Drawing.Point(113, 141);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(152, 27);
            this.comboTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convert from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Convert to:";
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_txt.Location = new System.Drawing.Point(12, 219);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(127, 19);
            this.display_txt.TabIndex = 6;
            this.display_txt.Text = "Converted amount:";
            // 
            // conv_btn
            // 
            this.conv_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conv_btn.Location = new System.Drawing.Point(144, 177);
            this.conv_btn.Name = "conv_btn";
            this.conv_btn.Size = new System.Drawing.Size(75, 23);
            this.conv_btn.TabIndex = 7;
            this.conv_btn.Text = "Convert";
            this.conv_btn.UseVisualStyleBackColor = true;
            this.conv_btn.Click += new System.EventHandler(this.conv_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.conv_btn);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTo);
            this.Controls.Add(this.comboFrom);
            this.Controls.Add(this.amount_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X-Rates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Button conv_btn;
    }
}

