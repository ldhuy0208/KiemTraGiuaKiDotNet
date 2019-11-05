namespace DanhBa
{
    partial class ThemLienLac
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tenLienLac = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_soDienThoai = new System.Windows.Forms.TextBox();
            this.textBox_diaChi = new System.Windows.Forms.TextBox();
            this.button_them = new System.Windows.Forms.Button();
            this.bindingSource_nhom = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListBox_nhom = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_nhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên liên lạc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhóm";
            // 
            // textBox_tenLienLac
            // 
            this.textBox_tenLienLac.Location = new System.Drawing.Point(223, 39);
            this.textBox_tenLienLac.Name = "textBox_tenLienLac";
            this.textBox_tenLienLac.Size = new System.Drawing.Size(212, 22);
            this.textBox_tenLienLac.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(223, 79);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(212, 22);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_soDienThoai
            // 
            this.textBox_soDienThoai.Location = new System.Drawing.Point(223, 117);
            this.textBox_soDienThoai.Name = "textBox_soDienThoai";
            this.textBox_soDienThoai.Size = new System.Drawing.Size(212, 22);
            this.textBox_soDienThoai.TabIndex = 7;
            // 
            // textBox_diaChi
            // 
            this.textBox_diaChi.Location = new System.Drawing.Point(223, 159);
            this.textBox_diaChi.Name = "textBox_diaChi";
            this.textBox_diaChi.Size = new System.Drawing.Size(212, 22);
            this.textBox_diaChi.TabIndex = 8;
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(223, 352);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 23);
            this.button_them.TabIndex = 10;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // checkedListBox_nhom
            // 
            this.checkedListBox_nhom.FormattingEnabled = true;
            this.checkedListBox_nhom.Location = new System.Drawing.Point(223, 202);
            this.checkedListBox_nhom.Name = "checkedListBox_nhom";
            this.checkedListBox_nhom.Size = new System.Drawing.Size(212, 89);
            this.checkedListBox_nhom.TabIndex = 14;
            // 
            // ThemLienLac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.checkedListBox_nhom);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.textBox_diaChi);
            this.Controls.Add(this.textBox_soDienThoai);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_tenLienLac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemLienLac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThenLienLac";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_nhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenLienLac;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_soDienThoai;
        private System.Windows.Forms.TextBox textBox_diaChi;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.BindingSource bindingSource_nhom;
        private System.Windows.Forms.CheckedListBox checkedListBox_nhom;
    }
}