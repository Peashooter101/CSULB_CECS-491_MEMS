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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.memsPictureBox = new System.Windows.Forms.PictureBox();
            this.accountInformationButton = new System.Windows.Forms.Button();
            this.addMachineButton = new System.Windows.Forms.Button();
            this.dbConnectInfoButton = new System.Windows.Forms.Button();
            this.changeLogButton = new System.Windows.Forms.Button();
            this.maintenanceLogButton = new System.Windows.Forms.Button();
            this.activeMachineButtons = new System.Windows.Forms.Button();
            this.newMaintenanceRequestButton = new System.Windows.Forms.Button();
            this.maintenanceReminderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.memsPictureBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 189);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // memsPictureBox
            // 
            this.memsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.memsPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.memsPictureBox.ErrorImage = global::MEMS.Properties.Resources.MEMS_logos_transparent;
            this.memsPictureBox.Image = global::MEMS.Properties.Resources.MEMS_logos_transparent;
            this.memsPictureBox.InitialImage = global::MEMS.Properties.Resources.MEMS_logos_transparent;
            this.memsPictureBox.Location = new System.Drawing.Point(3, 3);
            this.memsPictureBox.Name = "memsPictureBox";
            this.memsPictureBox.Size = new System.Drawing.Size(958, 182);
            this.memsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.memsPictureBox.TabIndex = 0;
            this.memsPictureBox.TabStop = false;
            // 
            // accountInformationButton
            // 
            this.accountInformationButton.Location = new System.Drawing.Point(56, 291);
            this.accountInformationButton.Name = "accountInformationButton";
            this.accountInformationButton.Size = new System.Drawing.Size(183, 53);
            this.accountInformationButton.TabIndex = 1;
            this.accountInformationButton.Text = "Account Information";
            this.accountInformationButton.UseVisualStyleBackColor = true;
            this.accountInformationButton.Click += new System.EventHandler(this.accountInformationButton_Click);
            // 
            // addMachineButton
            // 
            this.addMachineButton.Location = new System.Drawing.Point(738, 291);
            this.addMachineButton.Name = "addMachineButton";
            this.addMachineButton.Size = new System.Drawing.Size(183, 53);
            this.addMachineButton.TabIndex = 2;
            this.addMachineButton.Text = "Add Machine";
            this.addMachineButton.UseVisualStyleBackColor = true;
            this.addMachineButton.Click += new System.EventHandler(this.addMachineButton_Click);
            // 
            // dbConnectInfoButton
            // 
            this.dbConnectInfoButton.Location = new System.Drawing.Point(739, 361);
            this.dbConnectInfoButton.Name = "dbConnectInfoButton";
            this.dbConnectInfoButton.Size = new System.Drawing.Size(183, 53);
            this.dbConnectInfoButton.TabIndex = 4;
            this.dbConnectInfoButton.Text = "Database Connection Info";
            this.dbConnectInfoButton.UseVisualStyleBackColor = true;
            this.dbConnectInfoButton.Click += new System.EventHandler(this.dbConnectInfoButton_Click);
            // 
            // changeLogButton
            // 
            this.changeLogButton.Location = new System.Drawing.Point(57, 361);
            this.changeLogButton.Name = "changeLogButton";
            this.changeLogButton.Size = new System.Drawing.Size(183, 53);
            this.changeLogButton.TabIndex = 3;
            this.changeLogButton.Text = "Change Log ";
            this.changeLogButton.UseVisualStyleBackColor = true;
            this.changeLogButton.Click += new System.EventHandler(this.changeLogButton_Click);
            // 
            // maintenanceLogButton
            // 
            this.maintenanceLogButton.Location = new System.Drawing.Point(739, 433);
            this.maintenanceLogButton.Name = "maintenanceLogButton";
            this.maintenanceLogButton.Size = new System.Drawing.Size(183, 53);
            this.maintenanceLogButton.TabIndex = 6;
            this.maintenanceLogButton.Text = "Maintenance Log";
            this.maintenanceLogButton.UseVisualStyleBackColor = true;
            this.maintenanceLogButton.Click += new System.EventHandler(this.maintenanceLogButton_Click);
            // 
            // activeMachineButtons
            // 
            this.activeMachineButtons.Location = new System.Drawing.Point(57, 433);
            this.activeMachineButtons.Name = "activeMachineButtons";
            this.activeMachineButtons.Size = new System.Drawing.Size(183, 53);
            this.activeMachineButtons.TabIndex = 5;
            this.activeMachineButtons.Text = "List of Active Machines";
            this.activeMachineButtons.UseVisualStyleBackColor = true;
            this.activeMachineButtons.Click += new System.EventHandler(this.activeMachineButtons_Click);
            // 
            // newMaintenanceRequestButton
            // 
            this.newMaintenanceRequestButton.Location = new System.Drawing.Point(738, 506);
            this.newMaintenanceRequestButton.Name = "newMaintenanceRequestButton";
            this.newMaintenanceRequestButton.Size = new System.Drawing.Size(183, 53);
            this.newMaintenanceRequestButton.TabIndex = 8;
            this.newMaintenanceRequestButton.Text = "New Maintenance Request";
            this.newMaintenanceRequestButton.UseVisualStyleBackColor = true;
            this.newMaintenanceRequestButton.Click += new System.EventHandler(this.newMaintenanceRequestButton_Click);
            // 
            // maintenanceReminderButton
            // 
            this.maintenanceReminderButton.Location = new System.Drawing.Point(56, 506);
            this.maintenanceReminderButton.Name = "maintenanceReminderButton";
            this.maintenanceReminderButton.Size = new System.Drawing.Size(183, 53);
            this.maintenanceReminderButton.TabIndex = 7;
            this.maintenanceReminderButton.Text = "Maintenance Reminder";
            this.maintenanceReminderButton.UseVisualStyleBackColor = true;
            this.maintenanceReminderButton.Click += new System.EventHandler(this.maintenanceReminderButton_Click);
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 774);
            this.Controls.Add(this.newMaintenanceRequestButton);
            this.Controls.Add(this.maintenanceReminderButton);
            this.Controls.Add(this.maintenanceLogButton);
            this.Controls.Add(this.activeMachineButtons);
            this.Controls.Add(this.dbConnectInfoButton);
            this.Controls.Add(this.changeLogButton);
            this.Controls.Add(this.addMachineButton);
            this.Controls.Add(this.accountInformationButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainMenuWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button accountInformationButton;
        private System.Windows.Forms.Button addMachineButton;
        private System.Windows.Forms.Button dbConnectInfoButton;
        private System.Windows.Forms.Button changeLogButton;
        private System.Windows.Forms.Button maintenanceLogButton;
        private System.Windows.Forms.Button activeMachineButtons;
        private System.Windows.Forms.Button newMaintenanceRequestButton;
        private System.Windows.Forms.Button maintenanceReminderButton;

        private System.Windows.Forms.PictureBox memsPictureBox;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}