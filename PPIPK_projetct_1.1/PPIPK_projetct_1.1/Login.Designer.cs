﻿
namespace PPIPK_projetct_1._1
{
    partial class Login
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
            this.TbServer = new System.Windows.Forms.TextBox();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.LbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // TbServer
            // 
            this.TbServer.Location = new System.Drawing.Point(119, 64);
            this.TbServer.Name = "TbServer";
            this.TbServer.Size = new System.Drawing.Size(158, 20);
            this.TbServer.TabIndex = 1;
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(119, 114);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(158, 20);
            this.TbUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(119, 166);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(158, 20);
            this.TbPassword.TabIndex = 5;
            this.TbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(119, 230);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(113, 23);
            this.BtnLogIn.TabIndex = 6;
            this.BtnLogIn.Text = "Log in";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click_1);
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.ForeColor = System.Drawing.Color.Red;
            this.LbError.Location = new System.Drawing.Point(116, 286);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(0, 13);
            this.LbError.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 351);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbServer);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbServer;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Label LbError;
    }
}