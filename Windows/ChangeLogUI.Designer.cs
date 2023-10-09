namespace MEMS.Model
{
    partial class ChangeLogUI
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
            this.lblActiveMachines = new System.Windows.Forms.Label();
            this.lstChangeEvents = new System.Windows.Forms.ListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rchtxtbxItems = new System.Windows.Forms.RichTextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblActiveMachines
            // 
            this.lblActiveMachines.AutoSize = true;
            this.lblActiveMachines.Location = new System.Drawing.Point(52, 54);
            this.lblActiveMachines.Name = "lblActiveMachines";
            this.lblActiveMachines.Size = new System.Drawing.Size(124, 16);
            this.lblActiveMachines.TabIndex = 500;
            this.lblActiveMachines.Text = "Change Log Events";
            this.lblActiveMachines.Click += new System.EventHandler(this.lblActiveMachines_Click);
            // 
            // lstChangeEvents
            // 
            this.lstChangeEvents.FormattingEnabled = true;
            this.lstChangeEvents.ItemHeight = 16;
            this.lstChangeEvents.Location = new System.Drawing.Point(55, 73);
            this.lstChangeEvents.Name = "lstChangeEvents";
            this.lstChangeEvents.Size = new System.Drawing.Size(127, 356);
            this.lstChangeEvents.TabIndex = 0;
            this.lstChangeEvents.SelectedIndexChanged += new System.EventHandler(this.lstMachines_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(232, 391);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 38);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(360, 391);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 38);
            this.btnEmail.TabIndex = 3;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(637, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 38);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // rchtxtbxItems
            // 
            this.rchtxtbxItems.Location = new System.Drawing.Point(232, 192);
            this.rchtxtbxItems.Name = "rchtxtbxItems";
            this.rchtxtbxItems.Size = new System.Drawing.Size(505, 175);
            this.rchtxtbxItems.TabIndex = 1;
            this.rchtxtbxItems.Text = "";
            this.rchtxtbxItems.TextChanged += new System.EventHandler(this.rchtxtbxItems_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(229, 54);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 501;
            this.lblType.Text = "Type";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(229, 83);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 502;
            this.lblAuthor.Text = "Author";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(229, 115);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(36, 16);
            this.lblTimestamp.TabIndex = 503;
            this.lblTimestamp.Text = "Date";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(229, 147);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(47, 16);
            this.lblEntity.TabIndex = 504;
            this.lblEntity.Text = "********";
            // 
            // ChangeLogUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.rchtxtbxItems);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lstChangeEvents);
            this.Controls.Add(this.lblActiveMachines);
            this.Name = "ChangeLogUI";
            this.Text = "Change Log";
            this.Load += new System.EventHandler(this.ChangeLogUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActiveMachines;
        private System.Windows.Forms.ListBox lstChangeEvents;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rchtxtbxItems;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Label lblEntity;
    }
}