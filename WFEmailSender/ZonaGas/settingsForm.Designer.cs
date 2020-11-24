﻿namespace WFEmailSender
{
    partial class SettingsForm
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
            this.lblDefEmail = new System.Windows.Forms.Label();
            this.lblDefPW = new System.Windows.Forms.Label();
            this.lblEmailAndPwDescr = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblDefSourceDir = new System.Windows.Forms.Label();
            this.fbdDefSourceDir = new System.Windows.Forms.FolderBrowserDialog();
            this.tbDefSourceDir = new System.Windows.Forms.TextBox();
            this.btnDefSourceDir = new System.Windows.Forms.Button();
            this.btnDefDestDir = new System.Windows.Forms.Button();
            this.tbDefDestDir = new System.Windows.Forms.TextBox();
            this.lblDefDestDir = new System.Windows.Forms.Label();
            this.fbdDefDestDir = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDocx = new System.Windows.Forms.CheckBox();
            this.cbRtf = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDefEmail
            // 
            this.lblDefEmail.AutoSize = true;
            this.lblDefEmail.Location = new System.Drawing.Point(39, 57);
            this.lblDefEmail.Name = "lblDefEmail";
            this.lblDefEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDefEmail.TabIndex = 0;
            this.lblDefEmail.Text = "Email";
            // 
            // lblDefPW
            // 
            this.lblDefPW.AutoSize = true;
            this.lblDefPW.Location = new System.Drawing.Point(39, 87);
            this.lblDefPW.Name = "lblDefPW";
            this.lblDefPW.Size = new System.Drawing.Size(53, 13);
            this.lblDefPW.TabIndex = 1;
            this.lblDefPW.Text = "Password";
            // 
            // lblEmailAndPwDescr
            // 
            this.lblEmailAndPwDescr.AutoSize = true;
            this.lblEmailAndPwDescr.Location = new System.Drawing.Point(39, 29);
            this.lblEmailAndPwDescr.Name = "lblEmailAndPwDescr";
            this.lblEmailAndPwDescr.Size = new System.Drawing.Size(140, 13);
            this.lblEmailAndPwDescr.TabIndex = 2;
            this.lblEmailAndPwDescr.Text = "Default email and password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(103, 54);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(188, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(103, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(188, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // lblDefSourceDir
            // 
            this.lblDefSourceDir.AutoSize = true;
            this.lblDefSourceDir.Location = new System.Drawing.Point(39, 154);
            this.lblDefSourceDir.Name = "lblDefSourceDir";
            this.lblDefSourceDir.Size = new System.Drawing.Size(122, 13);
            this.lblDefSourceDir.TabIndex = 5;
            this.lblDefSourceDir.Text = "Default source directory:";
            // 
            // tbDefSourceDir
            // 
            this.tbDefSourceDir.Location = new System.Drawing.Point(42, 170);
            this.tbDefSourceDir.Name = "tbDefSourceDir";
            this.tbDefSourceDir.ReadOnly = true;
            this.tbDefSourceDir.Size = new System.Drawing.Size(277, 20);
            this.tbDefSourceDir.TabIndex = 6;
            // 
            // btnDefSourceDir
            // 
            this.btnDefSourceDir.Location = new System.Drawing.Point(325, 168);
            this.btnDefSourceDir.Name = "btnDefSourceDir";
            this.btnDefSourceDir.Size = new System.Drawing.Size(75, 23);
            this.btnDefSourceDir.TabIndex = 7;
            this.btnDefSourceDir.Text = "Browse";
            this.btnDefSourceDir.UseVisualStyleBackColor = true;
            this.btnDefSourceDir.Click += new System.EventHandler(this.btnDefSourceDir_Click);
            // 
            // btnDefDestDir
            // 
            this.btnDefDestDir.Location = new System.Drawing.Point(325, 223);
            this.btnDefDestDir.Name = "btnDefDestDir";
            this.btnDefDestDir.Size = new System.Drawing.Size(75, 23);
            this.btnDefDestDir.TabIndex = 10;
            this.btnDefDestDir.Text = "Browse";
            this.btnDefDestDir.UseVisualStyleBackColor = true;
            this.btnDefDestDir.Click += new System.EventHandler(this.btnDefDestDir_Click);
            // 
            // tbDefDestDir
            // 
            this.tbDefDestDir.Location = new System.Drawing.Point(42, 225);
            this.tbDefDestDir.Name = "tbDefDestDir";
            this.tbDefDestDir.ReadOnly = true;
            this.tbDefDestDir.Size = new System.Drawing.Size(277, 20);
            this.tbDefDestDir.TabIndex = 9;
            // 
            // lblDefDestDir
            // 
            this.lblDefDestDir.AutoSize = true;
            this.lblDefDestDir.Location = new System.Drawing.Point(39, 209);
            this.lblDefDestDir.Name = "lblDefDestDir";
            this.lblDefDestDir.Size = new System.Drawing.Size(141, 13);
            this.lblDefDestDir.TabIndex = 8;
            this.lblDefDestDir.Text = "Default destination directory:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(404, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDocx
            // 
            this.cbDocx.AutoSize = true;
            this.cbDocx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDocx.Location = new System.Drawing.Point(344, 57);
            this.cbDocx.Name = "cbDocx";
            this.cbDocx.Size = new System.Drawing.Size(49, 17);
            this.cbDocx.TabIndex = 12;
            this.cbDocx.Text = "docx";
            this.cbDocx.UseVisualStyleBackColor = true;
            this.cbDocx.CheckedChanged += new System.EventHandler(this.cbDocx_CheckedChanged);
            // 
            // cbRtf
            // 
            this.cbRtf.AutoSize = true;
            this.cbRtf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRtf.Location = new System.Drawing.Point(346, 83);
            this.cbRtf.Name = "cbRtf";
            this.cbRtf.Size = new System.Drawing.Size(47, 17);
            this.cbRtf.TabIndex = 13;
            this.cbRtf.Text = "rtf    ";
            this.cbRtf.UseVisualStyleBackColor = true;
            this.cbRtf.CheckedChanged += new System.EventHandler(this.cbRtf_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Source files format:";
            // 
            // tbAlias
            // 
            this.tbAlias.Location = new System.Drawing.Point(103, 106);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(188, 20);
            this.tbAlias.TabIndex = 16;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(39, 113);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 13);
            this.lblAlias.TabIndex = 15;
            this.lblAlias.Text = "Alias";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 295);
            this.Controls.Add(this.tbAlias);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRtf);
            this.Controls.Add(this.cbDocx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDefDestDir);
            this.Controls.Add(this.tbDefDestDir);
            this.Controls.Add(this.lblDefDestDir);
            this.Controls.Add(this.btnDefSourceDir);
            this.Controls.Add(this.tbDefSourceDir);
            this.Controls.Add(this.lblDefSourceDir);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmailAndPwDescr);
            this.Controls.Add(this.lblDefPW);
            this.Controls.Add(this.lblDefEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDefEmail;
        private System.Windows.Forms.Label lblDefPW;
        private System.Windows.Forms.Label lblEmailAndPwDescr;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblDefSourceDir;
        private System.Windows.Forms.FolderBrowserDialog fbdDefSourceDir;
        private System.Windows.Forms.TextBox tbDefSourceDir;
        private System.Windows.Forms.Button btnDefSourceDir;
        private System.Windows.Forms.Button btnDefDestDir;
        private System.Windows.Forms.TextBox tbDefDestDir;
        private System.Windows.Forms.Label lblDefDestDir;
        private System.Windows.Forms.FolderBrowserDialog fbdDefDestDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbDocx;
        private System.Windows.Forms.CheckBox cbRtf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.Label lblAlias;
    }
}