﻿namespace DanhBa
{
    partial class ThemNhom
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
            this.textBox_tenNhom = new System.Windows.Forms.TextBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // textBox_tenNhom
            // 
            this.textBox_tenNhom.Location = new System.Drawing.Point(176, 61);
            this.textBox_tenNhom.Name = "textBox_tenNhom";
            this.textBox_tenNhom.Size = new System.Drawing.Size(100, 22);
            this.textBox_tenNhom.TabIndex = 1;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(176, 105);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(100, 23);
            this.button_Them.TabIndex = 2;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // ThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 175);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.textBox_tenNhom);
            this.Controls.Add(this.label1);
            this.Name = "ThemNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNhom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tenNhom;
        private System.Windows.Forms.Button button_Them;
    }
}