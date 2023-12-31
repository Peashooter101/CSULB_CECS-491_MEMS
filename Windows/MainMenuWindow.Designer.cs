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
            this.printButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.printContainer = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountInformationButton
            // 
            this.accountInformationButton.BackColor = System.Drawing.Color.GhostWhite;
            this.accountInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.accountInformationButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInformationButton.Location = new System.Drawing.Point(14, 238);
            this.accountInformationButton.Name = "accountInformationButton";
            this.accountInformationButton.Size = new System.Drawing.Size(177, 61);
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
            this.addMachineButton.Location = new System.Drawing.Point(291, 238);
            this.addMachineButton.Name = "addMachineButton";
            this.addMachineButton.Size = new System.Drawing.Size(177, 61);
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
            this.dbConnectInfoButton.Location = new System.Drawing.Point(291, 305);
            this.dbConnectInfoButton.Name = "dbConnectInfoButton";
            this.dbConnectInfoButton.Size = new System.Drawing.Size(177, 61);
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
            this.changeLogButton.Location = new System.Drawing.Point(12, 305);
            this.changeLogButton.Name = "changeLogButton";
            this.changeLogButton.Size = new System.Drawing.Size(179, 61);
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
            this.maintenanceLogButton.Location = new System.Drawing.Point(291, 372);
            this.maintenanceLogButton.Name = "maintenanceLogButton";
            this.maintenanceLogButton.Size = new System.Drawing.Size(177, 61);
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
            this.activeMachineButtons.Location = new System.Drawing.Point(12, 372);
            this.activeMachineButtons.Name = "activeMachineButtons";
            this.activeMachineButtons.Size = new System.Drawing.Size(179, 61);
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
            this.newMaintenanceRequestButton.Location = new System.Drawing.Point(291, 439);
            this.newMaintenanceRequestButton.Name = "newMaintenanceRequestButton";
            this.newMaintenanceRequestButton.Size = new System.Drawing.Size(177, 61);
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
            this.maintenanceReminderButton.Location = new System.Drawing.Point(14, 439);
            this.maintenanceReminderButton.Name = "maintenanceReminderButton";
            this.maintenanceReminderButton.Size = new System.Drawing.Size(177, 61);
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
            this.pictureBox1.Size = new System.Drawing.Size(454, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // containerControl1
            // 
            this.containerControl1.BackColor = System.Drawing.Color.GhostWhite;
            this.containerControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.containerControl1.Location = new System.Drawing.Point(474, 14);
            this.containerControl1.Name = "containerControl1";
            this.containerControl1.Size = new System.Drawing.Size(925, 796);
            this.containerControl1.TabIndex = 10;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(1169, 816);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(103, 27);
            this.printButton.TabIndex = 11;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1296, 816);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 27);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // printContainer
            // 
            this.printContainer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printContainer_PrintPage);
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1410, 878);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.printButton);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Drawing.Printing.PrintDocument printContainer;

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button closeButton;

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