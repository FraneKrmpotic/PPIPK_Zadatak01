
namespace PPIPK_projetct_1._1
{
    partial class MainForm
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
            this.CbDatabase = new System.Windows.Forms.ComboBox();
            this.TbQuery = new System.Windows.Forms.TextBox();
            this.PnlResults = new System.Windows.Forms.Panel();
            this.PnlMessages = new System.Windows.Forms.Panel();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.FlpResults = new System.Windows.Forms.FlowLayoutPanel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PnlResults.SuspendLayout();
            this.PnlMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbDatabase
            // 
            this.CbDatabase.FormattingEnabled = true;
            this.CbDatabase.Location = new System.Drawing.Point(12, 12);
            this.CbDatabase.Name = "CbDatabase";
            this.CbDatabase.Size = new System.Drawing.Size(115, 21);
            this.CbDatabase.TabIndex = 0;
            this.CbDatabase.SelectedIndexChanged += new System.EventHandler(this.CbDatabase_SelectedIndexChanged);
            // 
            // TbQuery
            // 
            this.TbQuery.Location = new System.Drawing.Point(12, 39);
            this.TbQuery.Multiline = true;
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.Size = new System.Drawing.Size(870, 377);
            this.TbQuery.TabIndex = 1;
            // 
            // PnlResults
            // 
            this.PnlResults.Controls.Add(this.FlpResults);
            this.PnlResults.Location = new System.Drawing.Point(12, 432);
            this.PnlResults.Name = "PnlResults";
            this.PnlResults.Size = new System.Drawing.Size(427, 179);
            this.PnlResults.TabIndex = 2;
            // 
            // PnlMessages
            // 
            this.PnlMessages.Controls.Add(this.LblMessage);
            this.PnlMessages.Location = new System.Drawing.Point(462, 432);
            this.PnlMessages.Name = "PnlMessages";
            this.PnlMessages.Size = new System.Drawing.Size(420, 179);
            this.PnlMessages.TabIndex = 3;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(742, 10);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(140, 23);
            this.BtnExecute.TabIndex = 4;
            this.BtnExecute.Text = "Go";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // FlpResults
            // 
            this.FlpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpResults.Location = new System.Drawing.Point(0, 0);
            this.FlpResults.Name = "FlpResults";
            this.FlpResults.Size = new System.Drawing.Size(427, 179);
            this.FlpResults.TabIndex = 5;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(167, 81);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 13);
            this.LblMessage.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 623);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.PnlMessages);
            this.Controls.Add(this.PnlResults);
            this.Controls.Add(this.TbQuery);
            this.Controls.Add(this.CbDatabase);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.PnlResults.ResumeLayout(false);
            this.PnlMessages.ResumeLayout(false);
            this.PnlMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbDatabase;
        private System.Windows.Forms.TextBox TbQuery;
        private System.Windows.Forms.Panel PnlResults;
        private System.Windows.Forms.Panel PnlMessages;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.FlowLayoutPanel FlpResults;
        private System.Windows.Forms.Label LblMessage;
    }
}

