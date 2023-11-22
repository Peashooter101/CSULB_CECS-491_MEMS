using System.ComponentModel;

namespace MEMS.Windows
{
    partial class MainMenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuWindow));
            this.accountInformationButton = new System.Windows.Forms.Button();
            this.addMachineButton = new System.Windows.Forms.Button();
            this.dbConnectInfoButton = new System.Windows.Forms.Button();
            this.changeLogButton = new System.Windows.Forms.Button();
            this.maintenanceLogButton = new System.Windows.Forms.Button();
            this.activeMachineButtons = new System.Windows.Forms.Button();
            this.newMaintenanceRequestButton = new System.Windows.Forms.Button();
            this.maintenanceReminderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containerControl1 = new System.Windows.Forms.ContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountInformationButton
            // 
            this.accountInformationButton.BackColor = System.Drawing.Color.GhostWhite;
            this.accountInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.accountInformationButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInformationButton.Location = new System.Drawing.Point(43, 261);
            this.accountInformationButton.Name = "accountInformationButton";
            this.accountInformationButton.Size = new System.Drawing.Size(213, 61);
            this.accountInformationButton.TabIndex = 1;
            this.accountInformationButton.Text = "Account Information";
            this.accountInformationButton.UseVisualStyleBackColor = false;
            this.accountInformationButton.Click += new System.EventHandler(this.MDIAccountInformation_Click);
            // 
            // addMachineButton
            // 
            this.addMachineButton.BackColor = System.Drawing.Color.GhostWhite;
            this.addMachineButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addMachineButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMachineButton.Location = new System.Drawing.Point(400, 261);
            this.addMachineButton.Name = "addMachineButton";
            this.addMachineButton.Size = new System.Drawing.Size(213, 61);
            this.addMachineButton.TabIndex = 2;
            this.addMachineButton.Text = "Add Machine";
            this.addMachineButton.UseVisualStyleBackColor = false;
            this.addMachineButton.Click += new System.EventHandler(this.MDIAddMachineButton_Click);
            // 
            // dbConnectInfoButton
            // 
            this.dbConnectInfoButton.BackColor = System.Drawing.Color.GhostWhite;
            this.dbConnectInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dbConnectInfoButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbConnectInfoButton.Location = new System.Drawing.Point(401, 342);
            this.dbConnectInfoButton.Name = "dbConnectInfoButton";
            this.dbConnectInfoButton.Size = new System.Drawing.Size(213, 61);
            this.dbConnectInfoButton.TabIndex = 4;
            this.dbConnectInfoButton.Text = "Database Connection Info";
            this.dbConnectInfoButton.UseVisualStyleBackColor = false;
            this.dbConnectInfoButton.Click += new System.EventHandler(this.MDIDbConnectInfoButton_Click);
            // 
            // changeLogButton
            // 
            this.changeLogButton.BackColor = System.Drawing.Color.GhostWhite;
            this.changeLogButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeLogButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLogButton.Location = new System.Drawing.Point(44, 342);
            this.changeLogButton.Name = "changeLogButton";
            this.changeLogButton.Size = new System.Drawing.Size(213, 61);
            this.changeLogButton.TabIndex = 3;
            this.changeLogButton.Text = "Change Log ";
            this.changeLogButton.UseVisualStyleBackColor = false;
            this.changeLogButton.Click += new System.EventHandler(this.MDIChangeLogButton_Click);
            // 
            // maintenanceLogButton
            // 
            this.maintenanceLogButton.BackColor = System.Drawing.Color.GhostWhite;
            this.maintenanceLogButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maintenanceLogButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceLogButton.Location = new System.Drawing.Point(401, 425);
            this.maintenanceLogButton.Name = "maintenanceLogButton";
            this.maintenanceLogButton.Size = new System.Drawing.Size(213, 61);
            this.maintenanceLogButton.TabIndex = 6;
            this.maintenanceLogButton.Text = "Maintenance Log";
            this.maintenanceLogButton.UseVisualStyleBackColor = false;
            this.maintenanceLogButton.Click += new System.EventHandler(this.MDIMaintenanceLogButton_Click);
            // 
            // activeMachineButtons
            // 
            this.activeMachineButtons.BackColor = System.Drawing.Color.GhostWhite;
            this.activeMachineButtons.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.activeMachineButtons.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeMachineButtons.Location = new System.Drawing.Point(44, 425);
            this.activeMachineButtons.Name = "activeMachineButtons";
            this.activeMachineButtons.Size = new System.Drawing.Size(213, 61);
            this.activeMachineButtons.TabIndex = 5;
            this.activeMachineButtons.Text = "List of Active Machines";
            this.activeMachineButtons.UseVisualStyleBackColor = false;
            this.activeMachineButtons.Click += new System.EventHandler(this.MDIActiveMachineButtons_Click);
            // 
            // newMaintenanceRequestButton
            // 
            this.newMaintenanceRequestButton.BackColor = System.Drawing.Color.GhostWhite;
            this.newMaintenanceRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newMaintenanceRequestButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMaintenanceRequestButton.Location = new System.Drawing.Point(400, 509);
            this.newMaintenanceRequestButton.Name = "newMaintenanceRequestButton";
            this.newMaintenanceRequestButton.Size = new System.Drawing.Size(213, 61);
            this.newMaintenanceRequestButton.TabIndex = 8;
            this.newMaintenanceRequestButton.Text = "New Maintenance Request";
            this.newMaintenanceRequestButton.UseVisualStyleBackColor = false;
            this.newMaintenanceRequestButton.Click += new System.EventHandler(this.MDINewMaintenanceRequestButton_Click);
            // 
            // maintenanceReminderButton
            // 
            this.maintenanceReminderButton.BackColor = System.Drawing.Color.GhostWhite;
            this.maintenanceReminderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maintenanceReminderButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceReminderButton.Location = new System.Drawing.Point(43, 509);
            this.maintenanceReminderButton.Name = "maintenanceReminderButton";
            this.maintenanceReminderButton.Size = new System.Drawing.Size(213, 61);
            this.maintenanceReminderButton.TabIndex = 7;
            this.maintenanceReminderButton.Text = "Maintenance Reminder";
            this.maintenanceReminderButton.UseVisualStyleBackColor = false;
            this.maintenanceReminderButton.Click += new System.EventHandler(this.MDIMaintenanceReminderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // containerControl1
            // 
            this.containerControl1.BackColor = System.Drawing.Color.GhostWhite;
            this.containerControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.containerControl1.Location = new System.Drawing.Point(661, 14);
            this.containerControl1.Name = "containerControl1";
            this.containerControl1.Size = new System.Drawing.Size(986, 850);
            this.containerControl1.TabIndex = 10;
            this.containerControl1.Text = "containerControl1";
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1661, 878);
            this.Controls.Add(this.containerControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newMaintenanceRequestButton);
            this.Controls.Add(this.maintenanceReminderButton);
            this.Controls.Add(this.maintenanceLogButton);
            this.Controls.Add(this.activeMachineButtons);
            this.Controls.Add(this.dbConnectInfoButton);
            this.Controls.Add(this.changeLogButton);
            this.Controls.Add(this.addMachineButton);
            this.Controls.Add(this.accountInformationButton);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainMenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ContainerControl containerControl1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button accountInformationButton;
        private System.Windows.Forms.Button addMachineButton;
        private System.Windows.Forms.Button dbConnectInfoButton;
        private System.Windows.Forms.Button changeLogButton;
        private System.Windows.Forms.Button maintenanceLogButton;
        private System.Windows.Forms.Button activeMachineButtons;
        private System.Windows.Forms.Button newMaintenanceRequestButton;
        private System.Windows.Forms.Button maintenanceReminderButton;

        #endregion
    }
}