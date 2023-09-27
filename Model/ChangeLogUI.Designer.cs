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
            this.lstMachines = new System.Windows.Forms.ListBox();
            this.lstChangeLog = new System.Windows.Forms.ListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActiveMachines
            // 
            this.lblActiveMachines.AutoSize = true;
            this.lblActiveMachines.Location = new System.Drawing.Point(52, 28);
            this.lblActiveMachines.Name = "lblActiveMachines";
            this.lblActiveMachines.Size = new System.Drawing.Size(105, 16);
            this.lblActiveMachines.TabIndex = 0;
            this.lblActiveMachines.Text = "Active Machines";
            // 
            // lstMachines
            // 
            this.lstMachines.FormattingEnabled = true;
            this.lstMachines.ItemHeight = 16;
            this.lstMachines.Location = new System.Drawing.Point(55, 73);
            this.lstMachines.Name = "lstMachines";
            this.lstMachines.Size = new System.Drawing.Size(127, 356);
            this.lstMachines.TabIndex = 1;
            // 
            // lstChangeLog
            // 
            this.lstChangeLog.FormattingEnabled = true;
            this.lstChangeLog.ItemHeight = 16;
            this.lstChangeLog.Location = new System.Drawing.Point(232, 73);
            this.lstChangeLog.Name = "lstChangeLog";
            this.lstChangeLog.Size = new System.Drawing.Size(506, 276);
            this.lstChangeLog.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(241, 370);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 38);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(357, 370);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(103, 38);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(662, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // ChangeLogUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lstChangeLog);
            this.Controls.Add(this.lstMachines);
            this.Controls.Add(this.lblActiveMachines);
            this.Name = "ChangeLogUI";
            this.Text = "Change Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActiveMachines;
        private System.Windows.Forms.ListBox lstMachines;
        private System.Windows.Forms.ListBox lstChangeLog;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnBack;
    }
}