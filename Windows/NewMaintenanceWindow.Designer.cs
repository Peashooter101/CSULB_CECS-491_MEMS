using System.ComponentModel;

namespace MEMS.Windows
{
    partial class NewMaintenanceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMaintenanceWindow));
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.printButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.machineSelectionLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRequestButton = new System.Windows.Forms.Button();
            this.updateRequestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.machineDisplay = new System.Windows.Forms.ListBox();
            this.activeMachines = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.Width = -1;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 598);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(85, 40);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(673, 598);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 40);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // machineSelectionLabel
            // 
            this.machineSelectionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.machineSelectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.machineSelectionLabel.Location = new System.Drawing.Point(12, 9);
            this.machineSelectionLabel.Name = "machineSelectionLabel";
            this.machineSelectionLabel.Size = new System.Drawing.Size(275, 24);
            this.machineSelectionLabel.TabIndex = 20;
            this.machineSelectionLabel.Text = "Machine Selection";
            this.machineSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Company, this.Phone, this.Contact, this.Email, this.Issue, this.Severity, this.RequestType });
            this.dataGridView1.Location = new System.Drawing.Point(293, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 359);
            this.dataGridView1.TabIndex = 22;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Issue
            // 
            this.Issue.HeaderText = "Issue";
            this.Issue.Name = "Issue";
            // 
            // Severity
            // 
            this.Severity.HeaderText = "Severity";
            this.Severity.Name = "Severity";
            // 
            // RequestType
            // 
            this.RequestType.HeaderText = "Request Type";
            this.RequestType.Name = "RequestType";
            // 
            // addRequestButton
            // 
            this.addRequestButton.Location = new System.Drawing.Point(202, 598);
            this.addRequestButton.Name = "addRequestButton";
            this.addRequestButton.Size = new System.Drawing.Size(85, 40);
            this.addRequestButton.TabIndex = 23;
            this.addRequestButton.Text = "Add Request";
            this.addRequestButton.UseVisualStyleBackColor = true;
            this.addRequestButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // updateRequestButton
            // 
            this.updateRequestButton.Location = new System.Drawing.Point(299, 598);
            this.updateRequestButton.Name = "updateRequestButton";
            this.updateRequestButton.Size = new System.Drawing.Size(85, 40);
            this.updateRequestButton.TabIndex = 24;
            this.updateRequestButton.Text = "Update Request";
            this.updateRequestButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Machine Information ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // machineDisplay
            // 
            this.machineDisplay.BackColor = System.Drawing.Color.GhostWhite;
            this.machineDisplay.FormattingEnabled = true;
            this.machineDisplay.ItemHeight = 15;
            this.machineDisplay.Location = new System.Drawing.Point(293, 43);
            this.machineDisplay.Name = "machineDisplay";
            this.machineDisplay.Size = new System.Drawing.Size(465, 184);
            this.machineDisplay.TabIndex = 26;
            this.machineDisplay.SelectedIndexChanged += new System.EventHandler(this.MachineList_SelectedIndexChanged);
            // 
            // activeMachines
            // 
            this.activeMachines.BackColor = System.Drawing.Color.GhostWhite;
            this.activeMachines.FormattingEnabled = true;
            this.activeMachines.ItemHeight = 15;
            this.activeMachines.Location = new System.Drawing.Point(13, 43);
            this.activeMachines.Name = "activeMachines";
            this.activeMachines.Size = new System.Drawing.Size(274, 544);
            this.activeMachines.TabIndex = 27;
            this.activeMachines.SelectedIndexChanged += new System.EventHandler(this.MachineList_SelectedIndexChanged);
            // 
            // NewMaintenanceWindow
            // 
            this.AccessibleDescription = "New Maintenance Request";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(781, 644);
            this.Controls.Add(this.activeMachines);
            this.Controls.Add(this.machineDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateRequestButton);
            this.Controls.Add(this.addRequestButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.machineSelectionLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.printButton);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMaintenanceWindow";
            this.Text = "[MEMS] New Maintenance Request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMaintenanceWindow_FormClosing);
            this.Load += new System.EventHandler(this.NewMaintenanceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn RequestType;

        private System.Windows.Forms.DataGridViewTextBoxColumn Severity;

        private System.Windows.Forms.ListBox activeMachines;

        private System.Windows.Forms.ListBox machineDisplay;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue;

        private System.Windows.Forms.DataGridViewTextBoxColumn Company;

        private System.Windows.Forms.Button updateRequestButton;

        private System.Windows.Forms.Button addRequestButton;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label machineSelectionLabel;

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;

        #endregion
    }
}