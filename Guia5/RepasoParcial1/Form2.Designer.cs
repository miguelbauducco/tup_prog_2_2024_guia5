﻿namespace RepasoParcial1
{
    partial class Form2
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
            this.lbFVer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbFVer
            // 
            this.lbFVer.FormattingEnabled = true;
            this.lbFVer.Location = new System.Drawing.Point(114, 70);
            this.lbFVer.Name = "lbFVer";
            this.lbFVer.Size = new System.Drawing.Size(364, 147);
            this.lbFVer.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 313);
            this.Controls.Add(this.lbFVer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbFVer;
    }
}