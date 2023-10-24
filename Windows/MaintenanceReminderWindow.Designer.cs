using System.ComponentModel;

namespace MEMS.Windows
{
    partial class MaintenanceReminderWindow
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
            this.machineOverviewLabel = new System.Windows.Forms.Label();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.MachineNamee = new System.Windows.Forms.ColumnHeader();
            this.MachineUid = new System.Windows.Forms.ColumnHeader();
            this.MachineModel = new System.Windows.Forms.ColumnHeader();
            this.MachineManufacturer = new System.Windows.Forms.ColumnHeader();
            this.MachineZone = new System.Windows.Forms.ColumnHeader();
            this.machineListView = new System.Windows.Forms.ListView();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.vendorListView = new System.Windows.Forms.ListView();
            this.vendorContact = new System.Windows.Forms.ColumnHeader();
            this.vendorPhone = new System.Windows.Forms.ColumnHeader();
            this.vendorEmail = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // machineOverviewLabel
            // 
            this.machineOverviewLabel.BackColor = System.Drawing.Color.GhostWhite;
            this.machineOverviewLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.machineOverviewLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineOverviewLabel.Location = new System.Drawing.Point(12, 12);
            this.machineOverviewLabel.Name = "machineOverviewLabel";
            this.machineOverviewLabel.Size = new System.Drawing.Size(139, 22);
            this.machineOverviewLabel.TabIndex = 0;
            this.machineOverviewLabel.Text = "Machine Overview:";
            this.machineOverviewLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // MachineNamee
            // 
            this.MachineNamee.Text = "Name";
            this.MachineNamee.Width = 240;
            // 
            // MachineUid
            // 
            this.MachineUid.Text = "UID";
            this.MachineUid.Width = 71;
            // 
            // MachineModel
            // 
            this.MachineModel.DisplayIndex = 3;
            this.MachineModel.Text = "Model";
            this.MachineModel.Width = 135;
            // 
            // MachineManufacturer
            // 
            this.MachineManufacturer.DisplayIndex = 2;
            this.MachineManufacturer.Text = "Manufacturer";
            this.MachineManufacturer.Width = 90;
            // 
            // MachineZone
            // 
            this.MachineZone.Text = "Zone";
            // 
            // machineListView
            // 
            this.machineListView.BackColor = System.Drawing.Color.GhostWhite;
            this.machineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.MachineNamee, this.MachineUid, this.MachineModel, this.MachineManufacturer, this.MachineZone });
            this.machineListView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineListView.GridLines = true;
            this.machineListView.HideSelection = false;
            this.machineListView.Location = new System.Drawing.Point(13, 37);
            this.machineListView.Name = "machineListView";
            this.machineListView.Size = new System.Drawing.Size(598, 63);
            this.machineListView.TabIndex = 1;
            this.machineListView.UseCompatibleStateImageBehavior = false;
            this.machineListView.View = System.Windows.Forms.View.Details;
            // 
            // vendorLabel
            // 
            this.vendorLabel.BackColor = System.Drawing.Color.GhostWhite;
            this.vendorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vendorLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorLabel.Location = new System.Drawing.Point(13, 117);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(138, 22);
            this.vendorLabel.TabIndex = 2;
            this.vendorLabel.Text = "Vendor Information:";
            // 
            // vendorListView
            // 
            this.vendorListView.BackColor = System.Drawing.Color.GhostWhite;
            this.vendorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.vendorContact, this.vendorPhone, this.vendorEmail });
            this.vendorListView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListView.GridLines = true;
            this.vendorListView.HideSelection = false;
            this.vendorListView.Location = new System.Drawing.Point(12, 142);
            this.vendorListView.Name = "vendorListView";
            this.vendorListView.Size = new System.Drawing.Size(599, 63);
            this.vendorListView.TabIndex = 3;
            this.vendorListView.UseCompatibleStateImageBehavior = false;
            this.vendorListView.View = System.Windows.Forms.View.Details;
            // 
            // vendorContact
            // 
            this.vendorContact.Text = "Contact Name";
            this.vendorContact.Width = 240;
            // 
            // vendorPhone
            // 
            this.vendorPhone.Text = "Phone Number";
            this.vendorPhone.Width = 95;
            // 
            // vendorEmail
            // 
            this.vendorEmail.Text = "Email";
            this.vendorEmail.Width = 261;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maintenance Request ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(687, 402);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(99, 39);
            this.mainMenuButton.TabIndex = 6;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            // 
            // MaintenanceReminderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorListView);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.machineListView);
            this.Controls.Add(this.machineOverviewLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MaintenanceReminderWindow";
            this.Load += new System.EventHandler(this.MachineReminder_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button mainMenuButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.ListView vendorListView;
        private System.Windows.Forms.ColumnHeader vendorContact;
        private System.Windows.Forms.ColumnHeader vendorPhone;
        private System.Windows.Forms.ColumnHeader vendorEmail;

        private System.Windows.Forms.ColumnHeader MachineNamee;
        private System.Windows.Forms.ColumnHeader MachineUid;
        private System.Windows.Forms.ColumnHeader MachineModel;
        private System.Windows.Forms.ColumnHeader MachineManufacturer;
        private System.Windows.Forms.ColumnHeader MachineZone;
        private System.Windows.Forms.ListView machineListView;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGrid dataGrid1;

        private System.Windows.Forms.Label machineOverviewLabel;

        #endregion
    }
}