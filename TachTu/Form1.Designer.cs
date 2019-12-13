namespace TachTu
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.RichTextBox();
            this.txtketQua = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tách Từ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(4, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Câu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtketQua);
            this.groupBox2.Location = new System.Drawing.Point(394, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 418);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(7, 16);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(272, 389);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.Text = "";
            // 
            // txtketQua
            // 
            this.txtketQua.Location = new System.Drawing.Point(6, 16);
            this.txtketQua.Name = "txtketQua";
            this.txtketQua.Size = new System.Drawing.Size(272, 389);
            this.txtketQua.TabIndex = 0;
            this.txtketQua.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtketQua;
    }
}

