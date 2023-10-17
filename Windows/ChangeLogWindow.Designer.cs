using System.ComponentModel;

namespace MEMS
{
    partial class ChangeLogWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lstbxChangeEvents = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMachineOrUser = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.rchtxtbxDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtbxId = new System.Windows.Forms.TextBox();
            this.txtbxMachineOrUser = new System.Windows.Forms.TextBox();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.txtbxTimestamp = new System.Windows.Forms.TextBox();
            this.txtbxType = new System.Windows.Forms.TextBox();
            this.bttnMainMenu = new System.Windows.Forms.Button();
            this.bttnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxChangeEvents
            // 
            this.lstbxChangeEvents.FormattingEnabled = true;
            this.lstbxChangeEvents.ItemHeight = 16;
            this.lstbxChangeEvents.Location = new System.Drawing.Point(12, 9);
            this.lstbxChangeEvents.Name = "lstbxChangeEvents";
            this.lstbxChangeEvents.Size = new System.Drawing.Size(250, 468);
            this.lstbxChangeEvents.TabIndex = 0;
            this.lstbxChangeEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxChangeEvents_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(283, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // lblMachineOrUser
            // 
            this.lblMachineOrUser.Location = new System.Drawing.Point(283, 60);
            this.lblMachineOrUser.Name = "lblMachineOrUser";
            this.lblMachineOrUser.Size = new System.Drawing.Size(91, 21);
            this.lblMachineOrUser.TabIndex = 2;
            this.lblMachineOrUser.Text = "*********";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(283, 103);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 21);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Location = new System.Drawing.Point(282, 148);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(87, 21);
            this.lblTimestamp.TabIndex = 4;
            this.lblTimestamp.Text = "Timestamp:";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(283, 199);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 21);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // rchtxtbxDescription
            // 
            this.rchtxtbxDescription.Location = new System.Drawing.Point(282, 287);
            this.rchtxtbxDescription.Name = "rchtxtbxDescription";
            this.rchtxtbxDescription.Size = new System.Drawing.Size(449, 190);
            this.rchtxtbxDescription.TabIndex = 6;
            this.rchtxtbxDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(283, 253);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // txtbxId
            // 
            this.txtbxId.Location = new System.Drawing.Point(386, 9);
            this.txtbxId.Name = "txtbxId";
            this.txtbxId.Size = new System.Drawing.Size(70, 22);
            this.txtbxId.TabIndex = 8;
            // 
            // txtbxMachineOrUser
            // 
            this.txtbxMachineOrUser.Location = new System.Drawing.Point(386, 57);
            this.txtbxMachineOrUser.Name = "txtbxMachineOrUser";
            this.txtbxMachineOrUser.Size = new System.Drawing.Size(70, 22);
            this.txtbxMachineOrUser.TabIndex = 9;
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(386, 103);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(70, 22);
            this.txtbxAuthor.TabIndex = 10;
            // 
            // txtbxTimestamp
            // 
            this.txtbxTimestamp.Location = new System.Drawing.Point(386, 148);
            this.txtbxTimestamp.Name = "txtbxTimestamp";
            this.txtbxTimestamp.Size = new System.Drawing.Size(70, 22);
            this.txtbxTimestamp.TabIndex = 11;
            // 
            // txtbxType
            // 
            this.txtbxType.Location = new System.Drawing.Point(386, 199);
            this.txtbxType.Name = "txtbxType";
            this.txtbxType.Size = new System.Drawing.Size(70, 22);
            this.txtbxType.TabIndex = 12;
            // 
            // bttnMainMenu
            // 
            this.bttnMainMenu.Location = new System.Drawing.Point(12, 503);
            this.bttnMainMenu.Name = "bttnMainMenu";
            this.bttnMainMenu.Size = new System.Drawing.Size(100, 30);
            this.bttnMainMenu.TabIndex = 13;
            this.bttnMainMenu.Text = "Main Menu";
            this.bttnMainMenu.UseVisualStyleBackColor = true;
            // 
            // bttnPrint
            // 
            this.bttnPrint.Location = new System.Drawing.Point(283, 503);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(100, 30);
            this.bttnPrint.TabIndex = 14;
            this.bttnPrint.Text = "Print";
            this.bttnPrint.UseVisualStyleBackColor = true;
            // 
            // ChangeLogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 567);
            this.Controls.Add(this.bttnPrint);
            this.Controls.Add(this.bttnMainMenu);
            this.Controls.Add(this.txtbxType);
            this.Controls.Add(this.txtbxTimestamp);
            this.Controls.Add(this.txtbxAuthor);
            this.Controls.Add(this.txtbxMachineOrUser);
            this.Controls.Add(this.txtbxId);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rchtxtbxDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblMachineOrUser);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstbxChangeEvents);
            this.Name = "ChangeLogWindow";
            this.Text = "ChangeLogWindow";
            this.Load += new System.EventHandler(this.ChangeLogWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bttnMainMenu;
        private System.Windows.Forms.Button bttnPrint;

        private System.Windows.Forms.RichTextBox rchtxtbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtbxId;
        private System.Windows.Forms.TextBox txtbxMachineOrUser;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.TextBox txtbxTimestamp;
        private System.Windows.Forms.TextBox txtbxType;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMachineOrUser;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Label lblType;

        private System.Windows.Forms.ListBox lstbxChangeEvents;

        #endregion
    }
}