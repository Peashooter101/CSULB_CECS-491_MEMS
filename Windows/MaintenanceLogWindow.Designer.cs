namespace MEMS.Windows
{
    partial class MaintenanceLogWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceLogWindow));
            this.MachineList = new System.Windows.Forms.ListBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddMaintenanceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.MachineDetails = new System.Windows.Forms.ListBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MachineList
            // 
            this.MachineList.BackColor = System.Drawing.Color.GhostWhite;
            this.MachineList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MachineList.HorizontalScrollbar = true;
            this.MachineList.ItemHeight = 15;
            this.MachineList.Location = new System.Drawing.Point(30, 60);
            this.MachineList.Name = "MachineList";
            this.MachineList.Size = new System.Drawing.Size(151, 259);
            this.MachineList.TabIndex = 0;
            this.MachineList.SelectedIndexChanged += new System.EventHandler(this.MachineList_SelectedIndexChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(222, 293);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(87, 27);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save Log";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(222, 238);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(332, 27);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update Maintenance Entry";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddMaintenanceBtn
            // 
            this.AddMaintenanceBtn.Location = new System.Drawing.Point(222, 203);
            this.AddMaintenanceBtn.Name = "AddMaintenanceBtn";
            this.AddMaintenanceBtn.Size = new System.Drawing.Size(332, 27);
            this.AddMaintenanceBtn.TabIndex = 8;
            this.AddMaintenanceBtn.Text = "Add Maintenance Request";
            this.AddMaintenanceBtn.UseVisualStyleBackColor = true;
            this.AddMaintenanceBtn.Click += new System.EventHandler(this.AddMaintenanceBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Active Machines";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(222, 20);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(332, 22);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MachineDetails
            // 
            this.MachineDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.MachineDetails.FormattingEnabled = true;
            this.MachineDetails.ItemHeight = 15;
            this.MachineDetails.Location = new System.Drawing.Point(222, 60);
            this.MachineDetails.Margin = new System.Windows.Forms.Padding(2);
            this.MachineDetails.Name = "MachineDetails";
            this.MachineDetails.Size = new System.Drawing.Size(331, 124);
            this.MachineDetails.TabIndex = 19;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(486, 293);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(68, 27);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MaintenanceLogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(586, 337);
            this.Controls.Add(this.MachineDetails);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddMaintenanceBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.MachineList);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaintenanceLogWindow";
            this.Text = "[MEMS] Maintenance Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaintenanceLogWindow_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox MachineDetails;

        private System.Windows.Forms.Label lblInfo;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button AddMaintenanceBtn;

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button BackBtn;

        private System.Windows.Forms.Button SaveBtn;

        private System.Windows.Forms.ListBox MachineList;

        #endregion
    }
}