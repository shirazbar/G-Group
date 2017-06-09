namespace Memos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.timeFld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.memosComboBox = new System.Windows.Forms.ComboBox();
            this.textFld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.timeFld);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.memosComboBox);
            this.panel1.Controls.Add(this.textFld);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 332);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose a memo:";
            // 
            // clearBtn
            // 
            this.clearBtn.Image = global::Memos.Properties.Resources.clear;
            this.clearBtn.Location = new System.Drawing.Point(511, 248);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(34, 34);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Image = global::Memos.Properties.Resources.plus;
            this.addBtn.Location = new System.Drawing.Point(341, 248);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(37, 34);
            this.addBtn.TabIndex = 7;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // timeFld
            // 
            this.timeFld.Location = new System.Drawing.Point(143, 294);
            this.timeFld.Name = "timeFld";
            this.timeFld.Size = new System.Drawing.Size(140, 20);
            this.timeFld.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last edited in :";
            // 
            // removeBtn
            // 
            this.removeBtn.Image = global::Memos.Properties.Resources.delete;
            this.removeBtn.Location = new System.Drawing.Point(396, 248);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(35, 34);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::Memos.Properties.Resources.save;
            this.saveBtn.Location = new System.Drawing.Point(457, 248);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(34, 34);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // memosComboBox
            // 
            this.memosComboBox.FormattingEnabled = true;
            this.memosComboBox.Location = new System.Drawing.Point(330, 117);
            this.memosComboBox.Name = "memosComboBox";
            this.memosComboBox.Size = new System.Drawing.Size(242, 21);
            this.memosComboBox.TabIndex = 2;
            this.memosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textFld
            // 
            this.textFld.Location = new System.Drawing.Point(16, 27);
            this.textFld.Multiline = true;
            this.textFld.Name = "textFld";
            this.textFld.Size = new System.Drawing.Size(293, 261);
            this.textFld.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Please press clean before adding new memo !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 332);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Memos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox memosComboBox;
        private System.Windows.Forms.TextBox textFld;
        private System.Windows.Forms.TextBox timeFld;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

