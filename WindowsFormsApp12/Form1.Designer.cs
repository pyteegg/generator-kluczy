﻿namespace WindowsFormsApp12
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtklucz = new System.Windows.Forms.TextBox();
            this.txtdlkl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "klucz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "długość klucza";
            // 
            // txtklucz
            // 
            this.txtklucz.Location = new System.Drawing.Point(319, 68);
            this.txtklucz.Name = "txtklucz";
            this.txtklucz.Size = new System.Drawing.Size(100, 20);
            this.txtklucz.TabIndex = 2;
            // 
            // txtdlkl
            // 
            this.txtdlkl.Location = new System.Drawing.Point(319, 135);
            this.txtdlkl.Name = "txtdlkl";
            this.txtdlkl.Size = new System.Drawing.Size(100, 20);
            this.txtdlkl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdlkl);
            this.Controls.Add(this.txtklucz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtklucz;
        private System.Windows.Forms.TextBox txtdlkl;
        private System.Windows.Forms.Button button1;
    }
}

